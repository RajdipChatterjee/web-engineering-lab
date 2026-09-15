namespace backend.Exceptions
{
    public class ForbiddenException : AppException
    {
        public ForbiddenException(string message, int statusCode) : base(message, statusCode)
        {
        }
    }
}