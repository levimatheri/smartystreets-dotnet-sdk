namespace Smarty.Net.Core.Apis.Shared.Exceptions;

public class SmartyException : Exception
{
    public SmartyException()
    {
    }

    public SmartyException(string message)
        : base(message)
    {
    }

    public SmartyException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}