namespace backend.Exceptions
{
    public class UnauthorizedException : AppException
    {
        public UnauthorizedException(string message, int statusCode) : base(message, statusCode)
        {
        }
    }
}
