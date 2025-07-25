using CarManagement.Core.Common;

namespace CarManagement.Core.Models;

public class Brand : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? LogoUrl { get; set; }
}
