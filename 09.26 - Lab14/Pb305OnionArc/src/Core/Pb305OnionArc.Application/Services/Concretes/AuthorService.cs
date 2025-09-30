using Microsoft.EntityFrameworkCore;

namespace Pb305OnionArc.Application.Services.Concretes;

public class AuthorService(IAppDbContext context, IMapper mapper) : IAuthorService
{
    public async Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto)
    {
        // Cannot 2 authors with the same name
        var existingAuthor = await context.Authors.FirstOrDefaultAsync(x => x.Name == createAuthorDto.Name);
        if (existingAuthor != null)
            throw new ConflictException("An author with the same name already exists.");


        var author = mapper.Map<Author>(createAuthorDto);
        await context.Authors.AddAsync(author);
        await context.SaveChangesAsync();
        var authorDto = mapper.Map<AuthorDto>(author);

        return authorDto;
    }

    public async Task<bool> DeleteAuthorAsync(string id)
    {
        var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        if (author == null)
            throw new NotFoundException("Author not found");
        context.Authors.Remove(author);
        var result = context.SaveChangesAsync().Result > 0;
        return result;
    }

    public async Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync()
    {
        var values = await context.Authors
            .IgnoreQueryFilters()
            .ToListAsync();
        return mapper.Map<List<AuthorDto>>(values);
    }

    public async Task<AuthorDto?> GetAuthorByIdAsync(string id)
    {
        var author = await context.Authors.FirstOrDefaultAsync(x=>x.Id == id);
        if (author == null)
            throw new NotFoundException("Author not found");
        return mapper.Map<AuthorDto>(author);
    }
}
