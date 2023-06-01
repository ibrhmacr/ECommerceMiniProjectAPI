using Business.Services;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : Controller
{
    private IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("GetProductsByCategoryId")]
    public IActionResult GetProductsByCategoryId(int id)
    {
        var result = _productService.GetProductsByCategoryId(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetProductsByUserId")]
    public IActionResult GetProductsByUserId(int id)
    {
        var result = _productService.GetProductsByUserId(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetProductById")]
    public IActionResult GetProductById(int id)
    {
        var result = _productService.GetById(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddProduct")]
    public IActionResult Add(Product product)
    {
        var result = _productService.Add(product);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("DeleteProduct")]
    public IActionResult Delete(Product product)
    {
        var result = _productService.Delete(product);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("UpdateProduct")]
    public IActionResult Update(Product product)
    {
        var result = _productService.Update(product);
        return result.Success ? Ok(result) : BadRequest(result);
    }
}