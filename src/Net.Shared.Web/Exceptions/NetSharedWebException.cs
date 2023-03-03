using Net.Shared.Exceptions;

namespace Net.Shared.Web.Exceptions;

public sealed class NetSharedWebException : NetSharedException
{
    public NetSharedWebException(string message) : base(message)
    {
    }

    public NetSharedWebException(Exception exception) : base(exception)
    {
    }
}