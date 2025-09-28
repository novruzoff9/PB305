namespace Pb305OnionArc.Application.Common.Mappers;

public class AuthorProfiler : Profile
{
    public AuthorProfiler()
    {
        //CreateMap<Author, AuthorDto>().ReverseMap();
        //CreateMap<CreateAuthorDto, Author>();

        CreateMap<Author, AuthorDto>()
            .ConstructUsing(a => new(a.Name, a.BirthDate));

        CreateMap<CreateAuthorDto, Author>()
            .ConstructUsing(dto => new Author(dto.Name, dto.BirthDate, dto.Address));
    }
}
