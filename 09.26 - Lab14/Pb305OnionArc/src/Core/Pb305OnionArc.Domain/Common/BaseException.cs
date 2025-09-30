namespace Pb305OnionArc.Domain.Common;

public class BaseException(string message, int statusCode) : Exception(message)
{
    public int StatusCode { get; init; } = statusCode;
}
