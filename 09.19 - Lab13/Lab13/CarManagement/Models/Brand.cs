using CarManagement.Models.Common;

namespace CarManagement.Models;

public class Brand : BaseEntity
{
    public string Name { get; private set; }
    public string Country { get; private set; }
    public DateTime CreatedAt { get; init; }
    public ICollection<Model>? Models { get; set; }

    public Brand(string name, string country)
    {
        Name = name;
        Country = country;
        CreatedAt = DateTime.Now;
    }

    public void Update(string name, string country)
    {
        Name = name;
        Country = country;
    }
}
