using Business.Interfaces;
using Entities.DTOs.Author;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class AuthorsController(IAuthorService authorService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await authorService.GetAllAsync();
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateAuthorDto request)
    {
        var result = await authorService.AddAsync(request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Update(Guid id, UpdateAuthorDto request)
    {
        var result = await authorService.UpdateAsync(id, request);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(Guid id)
    {
        var result = await authorService.DeleteByIdAsync(id);
        return Ok(result);
    }
}
