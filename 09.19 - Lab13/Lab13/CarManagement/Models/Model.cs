using CarManagement.Models.Common;

namespace CarManagement.Models;

public class Model : BaseEntity
{
    public string Name { get; private set; }
    public int BrandId { get; private set; }
    public Brand? Brand { get; private set; }
    public DateTime CreatedAt { get; init; }
    public Model(string name, int brandId)
    {
        Name = name;
        BrandId = brandId;
        CreatedAt = DateTime.Now;
    }
}
