using Pb305OnionArc.Domain.ValueObjects;

namespace Pb305OnionArc.Application.Common.Models.Author;

public record AuthorDto(string Id, string Name, DateTime BirthDate, bool IsDeleted, DateTime? DeletedAt, string? DeletedBy);

public record CreateAuthorDto(string Name, DateTime BirthDate);
