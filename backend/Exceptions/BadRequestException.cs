namespace backend.Exceptions
{
    public class BadRequestException : AppException
    {
        public BadRequestException(string message, int statusCode) : base(message, statusCode)
        {
        }
    }
}
