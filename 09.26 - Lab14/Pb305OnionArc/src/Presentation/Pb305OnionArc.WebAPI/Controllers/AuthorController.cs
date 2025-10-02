using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pb305OnionArc.Application.Common.Models.Author;
using Pb305OnionArc.Application.Common.Models.Response;
using Pb305OnionArc.Application.Services.Abstractions;

namespace Pb305OnionArc.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController(IAuthorService authorService) : ControllerBase
{
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAllAuthors()
    {
        var authors = await authorService.GetAllAuthorsAsync();
        var response = Response<IEnumerable<AuthorDto>>.Success(authors, 200);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthorById(string id)
    {
        var author = await authorService.GetAuthorByIdAsync(id);
        var response = Response<AuthorDto>.Success(author, 200);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorDto createAuthorDto)
    {
        var author = await authorService.CreateAuthorAsync(createAuthorDto);
        var response = Response<AuthorDto>.Success(author, 201);
        return Ok(response);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuthor(string id)
    {
        var result = await authorService.DeleteAuthorAsync(id);
        var response = Response<bool>.Success(result, 200);
        return Ok(response);
    }

}
