using Business.Services;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : Controller
{
    private ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetCategories")]
    public IActionResult GetCategories()
    {
        var result = _categoryService.GetCategories();
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetCategoryById")]
    public IActionResult GetCategoriesById(int id)
    {
        var result = _categoryService.GetCategoryById(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Add")]
    public IActionResult Add(Category category)
    {
        var result = _categoryService.Add(category);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Update")]
    public IActionResult Update(Category category)
    {
        var result = _categoryService.Update(category);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Delete")]
    public IActionResult Delete(Category category)
    {
        var result = _categoryService.Delete(category);
        return result.Success ? Ok(result) : BadRequest(result);
    }
}