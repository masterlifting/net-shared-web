using Net.Shared.Exceptions;

namespace Net.Shared.Web.Abstractions.Models.Exceptions;

public sealed class WebException : NetSharedException
{
    public WebException(string message) : base(message)
    {
    }

    public WebException(Exception exception) : base(exception)
    {
    }
}
