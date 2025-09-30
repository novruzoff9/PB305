namespace Pb305OnionArc.Domain.Models;

public class Author : BaseEntity, ISoftDeletable
{
    private Author() : base() { } // For EF Core
    public Author(string name, DateTime birthDate) : base()
    {
        Name = name;
        BirthDate = birthDate;
    }
    public string Name { get; private set; }
    public DateTime BirthDate { get; init; }
    //public Address Address { get; private set; }
    public List<Book>? Books { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }

    public void SoftDelete(string deletedBy)
    {
        IsDeleted = true;
        DeletedAt = DateTime.UtcNow;
        DeletedBy = deletedBy;
    }

    //public void UpdateAddress(Address newAddress)
    //{
    //    Address = newAddress;
    //}
}
