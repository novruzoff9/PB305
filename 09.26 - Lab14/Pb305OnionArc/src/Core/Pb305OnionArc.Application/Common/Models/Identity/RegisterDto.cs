using System.ComponentModel.DataAnnotations;

namespace Pb305OnionArc.Application.Common.Models.Identity;

public record RegisterDto
{
    [Required, MaxLength(100)]
    public string FirstName { get; init; } = null!;
    
    [Required, MaxLength(100)]
    public string LastName { get; init; } = null!;
    
    [Required, EmailAddress]
    public string Email { get; init; } = null!;
    
    [Required, MaxLength(50)]
    public string UserName { get; init; } = null!;
    
    [Required, MinLength(6)]
    public string Password { get; init; } = null!;
    
    [Required, Compare(nameof(Password))]
    public string ConfirmPassword { get; init; } = null!;
}