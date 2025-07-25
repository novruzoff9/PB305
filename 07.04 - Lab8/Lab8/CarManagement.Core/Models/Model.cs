using CarManagement.Core.Common;

namespace CarManagement.Core.Models;

public class Model : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
}
