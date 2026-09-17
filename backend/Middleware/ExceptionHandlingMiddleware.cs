//using backend.Exceptions;

//namespace backend.Middleware
//{
//    public class ExceptionHandlingMiddleware
//    {
//        private readonly RequestDelegate _next;
//        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

//        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
//        {
//            _next = next;
//            _logger = logger;
//        }

//        public async Task InvokeAsync(HttpContext context)
//        {
//            var correlationId =
//                context.Request.Headers["X-Correlation-ID"].FirstOrDefault()
//                ?? Guid.NewGuid().ToString();

//            context.Response.Headers["X-Correlation-ID"] = correlationId;

//            using (_logger.BeginScope(new Dictionary<string, object>
//            {
//                ["CorrelationId"] = correlationId
//            }))
//            {
//                try
//                {
//                    await _next(context);
//                }
//                catch (Exception ex)
//                {
//                    _logger.LogError(ex, "An unexpected error occurred.");
//                    await HandleExceptionAsync(context, ex);
//                }
//            }
//        }

//        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
//        {
//            var statusCode = exception is AppException appException
//                ? appException.StatusCode
//                : StatusCodes.Status500InternalServerError;

//            context.Response.StatusCode = statusCode;
//            context.Response.ContentType = "application/json";

//            var response = new
//            {
//                status = statusCode,
//                message = exception is AppException
//                  ? exception.Message
//                  : "An unexpected error occurred."
//            };

//            await context.Response.WriteAsJsonAsync(response);
//        }
//    }
//}


using backend.Exceptions;

namespace backend.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred.");

                var statusCode = ex is AppException appException
                    ? appException.StatusCode
                    : StatusCodes.Status500InternalServerError;

                var message = ex is AppException
                    ? ex.Message
                    : "An unexpected error occurred.";

                context.Response.StatusCode = statusCode;
                context.Response.ContentType = "application/json";

                var response = new
                {
                    status = statusCode,
                    message = message
                };

                if (ex is AppException)
                {
                    _logger.LogWarning("Application exception: {Message}", ex.Message);
                }
                else
                {
                    _logger.LogError(ex, "An unexpected error occurred.");
                }

                await context.Response.WriteAsJsonAsync(response);
            }
        }
    }
}