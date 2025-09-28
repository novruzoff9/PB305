using AutoMapper;
using CarManagement.Data;
using CarManagement.Dtos.Brand;
using Microsoft.AspNetCore.Mvc;

namespace CarManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandController
    (AppDbContext context,
    IMapper mapper)
    : ControllerBase
{
    [HttpGet]
    public IActionResult GetBrands()
    {
        var brands = context.Brands.ToList();
        return Ok(brands);
    }
    [HttpGet("{id}")]
    public IActionResult GetBrand(int id)
    {
        var brand = context.Brands.FirstOrDefault(x=>x.Id == id);
        if (brand == null) return NotFound();
        return Ok(brand);
    }
    [HttpPost]
    public IActionResult CreateBrand([FromBody] CreateBrandDto brandDto)
    {
        var brand = mapper.Map<Brand>(brandDto);
        context.Brands.Add(brand);
        context.SaveChanges();
        return Ok(brand);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateBrand(int id, [FromBody] UpdateBrandDto updatedBrand)
    {
        var brand = context.Brands.FirstOrDefault(x => x.Id == id);
        if (brand == null) return NotFound();
        // brand { Name = "Audi", Country = "Germany"}
        // updatedBrand { Name = "Audi", Country = "Brazil"}
        brand.Update(updatedBrand.Name, updatedBrand.Country);
        context.SaveChanges();
        return Ok(brand);
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteBrand(int id)
    {
        var brand = context.Brands.FirstOrDefault(x => x.Id == id);
        if (brand == null) return NotFound();
        context.Brands.Remove(brand);
        context.SaveChanges();
        return NoContent();
    }
}
