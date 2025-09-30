public class CustomUnauthorizedException : Exception
{
    public CustomUnauthorizedException() : base()
    {

    }
    public CustomUnauthorizedException(string message) : base(message)
    {

    }
    public CustomUnauthorizedException(string message, Exception innerException) : base(message, innerException)
    {
        
    }
}