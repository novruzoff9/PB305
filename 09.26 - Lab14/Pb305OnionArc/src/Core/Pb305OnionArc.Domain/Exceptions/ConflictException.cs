namespace Pb305OnionArc.Domain.Exceptions;

public class ConflictException (string message) : BaseException(message, 409)
{
}
