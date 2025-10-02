using System.ComponentModel.DataAnnotations;

namespace Pb305OnionArc.Application.Common.Models.Identity;

public record UpdateUserDto
{
    [Required, MaxLength(100)]
    public string FirstName { get; init; } = null!;
    
    [Required, MaxLength(100)]
    public string LastName { get; init; } = null!;
    
    [Required, EmailAddress]
    public string Email { get; init; } = null!;
}