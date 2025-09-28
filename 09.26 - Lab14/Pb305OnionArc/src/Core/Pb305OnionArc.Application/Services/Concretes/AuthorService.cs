using Microsoft.EntityFrameworkCore;

namespace Pb305OnionArc.Application.Services.Concretes;

public class AuthorService(IAppDbContext context, IMapper mapper) : IAuthorService
{
    public async Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto)
    {
        var author = mapper.Map<Author>(createAuthorDto);
        await context.Authors.AddAsync(author);
        await context.SaveChangesAsync();
        var authorDto = mapper.Map<AuthorDto>(author);
        return authorDto;
    }

    public Task<bool> DeleteAuthorAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync()
    {
        var values = await context.Authors.ToListAsync();
        return mapper.Map<List<AuthorDto>>(values);
    }

    public Task<AuthorDto?> GetAuthorByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
}
