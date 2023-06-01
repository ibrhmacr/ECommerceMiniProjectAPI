using Business.Services;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CreditCardsController : Controller
{
    private ICreditCardService _creditCardService;

    public CreditCardsController(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    [HttpGet("GetCardsByUserId")]
    public IActionResult GetCardsByUserId(int id)
    {
        var result = _creditCardService.GetCardsByUserId(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetCardById")]
    public IActionResult GetById(int id)
    {
        var result = _creditCardService.GetById(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Add")]
    public IActionResult Add(CreditCard creditCard)
    {
        var result = _creditCardService.Add(creditCard);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Update")]
    public IActionResult Update(CreditCard creditCard)
    {
        var result = _creditCardService.Update(creditCard);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("Delete")]
    public IActionResult Delete(CreditCard creditCard)
    {
        var result = _creditCardService.Delete(creditCard);
        return result.Success ? Ok(result) : BadRequest(result);
    }
}