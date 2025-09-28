namespace Pb305OnionArc.Application.Services.Abstractions;

public interface IAuthorService
{
    Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync();
    Task<AuthorDto?> GetAuthorByIdAsync(string id);
    Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto);
    //Task<AuthorDto?> UpdateAuthorAsync(int id, UpdateAuthorDto updateAuthorDto);
    Task<bool> DeleteAuthorAsync(string id);
}
