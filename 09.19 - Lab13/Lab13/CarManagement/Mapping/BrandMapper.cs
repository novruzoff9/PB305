using AutoMapper;
using CarManagement.Dtos.Brand;

namespace CarManagement.Mapping;

public class BrandMapper : Profile
{
    public BrandMapper()
    {
        CreateMap<CreateBrandDto, Brand>()
            .ConstructUsing(dto => new Brand(dto.Name, dto.Country));
    }
}
