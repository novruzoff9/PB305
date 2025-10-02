using System.ComponentModel.DataAnnotations;

namespace Pb305OnionArc.Application.Common.Models.Identity;

public record LoginDto
{
    [Required, EmailAddress]
    public string Email { get; init; } = null!;
    
    [Required]
    public string Password { get; init; } = null!;
    
    public bool RememberMe { get; init; } = false;
}