namespace backend.Exceptions
{
    public class ValidationException : AppException
    {
        public ValidationException(string message, int statusCode) : base(message, statusCode)
        {
        }
    }
}
