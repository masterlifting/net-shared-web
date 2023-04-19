namespace Net.Shared.Web.Exceptions;

public sealed class WebException : Net.Shared.Exception
{
    public WebException(string message) : base(message)
    {
    }

    public WebException(System.Exception exception) : base(exception)
    {
    }
}