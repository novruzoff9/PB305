using Pb305OnionArc.Domain.ValueObjects;

namespace Pb305OnionArc.Application.Common.Models.Author;

public record AuthorDto(string Name, DateTime BirthDate);

public record CreateAuthorDto(string Name, DateTime BirthDate, Address Address);
