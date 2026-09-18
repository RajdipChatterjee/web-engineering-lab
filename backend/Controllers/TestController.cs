using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableRateLimiting("fixed")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly IEmailService _emailService;

        public TestController(ILogger<TestController> logger, IEmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        [HttpGet("test-exception")]
        public IActionResult TestException()
        {
            //var userId = "user-123";
            //var taskId = "task-456";

            //_logger.LogInformation(
            //    "User {UserId} requested Task {TaskId}"    ,
            //    userId,
            //    taskId
            //);


            //using (_logger.BeginScope(new Dictionary<string, object>
            //{
            //    ["UserId"] = "user-123",
            //    ["RequestId"] = "req-456"
            //}))
            //{
            //    _logger.LogInformation("Starting operation");
            //    _logger.LogWarning("Something interesting happened");
            //    _logger.LogInformation("Operation completed");
            //}

            //_logger.LogTrace("Trace message");
            //_logger.LogDebug("Debug message");
            //_logger.LogInformation("Information message");
            //_logger.LogWarning("Warning message");
            //_logger.LogError("Error message");
            //_logger.LogCritical("Critical message");

            //throw new Exception("This is a test exception.");
            return Ok("Take your data boy.");
        }

        [HttpPost("test-email")]
        public async Task<IActionResult> TestEmail()
        {
            await _emailService.SendEmailAsync(
                "rajdipchatterjee3000@gmail.com",
                "Test Email",
                "Hello from ASP.NET Core!"
            );

            return Ok(new
            {
                message = "Email sent successfully."
            });
        }
    }
}
