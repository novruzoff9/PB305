namespace Pb305OnionArc.Domain.Common;

public abstract class BaseEntity
{
    public string Id { get; init; }
    protected BaseEntity()
    {
        Id = Guid.NewGuid().ToString();
    }
}