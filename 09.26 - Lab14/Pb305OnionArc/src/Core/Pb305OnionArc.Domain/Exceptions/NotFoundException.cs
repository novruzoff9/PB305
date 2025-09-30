namespace Pb305OnionArc.Domain.Exceptions;

public class NotFoundException(string message) : BaseException(message, 404)
{
}
