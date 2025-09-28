using Pb305OnionArc.Domain.ValueObjects;

namespace Pb305OnionArc.Domain.Models;

public class Author : BaseEntity
{
    private Author() : base() { } // For EF Core
    public Author(string name, DateTime birthDate, Address address) : base()
    {
        Name = name;
        BirthDate = birthDate;
        Address = address;
    }
    public string Name { get; private set; }
    public DateTime BirthDate { get; init; }
    public Address Address { get; private set; }
    public List<Book>? Books { get; private set; }

    public void UpdateAddress(Address newAddress)
    {
        Address = newAddress;
    }
}
