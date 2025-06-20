namespace CardSystem.Exceptions;

public class ConflictException:Exception
{
    public ConflictException():base()
    {

    }
    public ConflictException(string massage):base(massage)
    {

    }
}
