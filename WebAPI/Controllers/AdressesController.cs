using Business.Services;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]

public class AdressesController : Controller
{
    private IAddressService _addressService;

    public AdressesController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("GetAdresses")]
    public IActionResult GetAdresses()
    {
        var result = _addressService.GetAll();
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpGet("GetAdressById")]
    public IActionResult GetAdressById(int id)
    {
        var result = _addressService.GetById(id);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpDelete("DeleteAdress")]
    public IActionResult DeleteAdress(Address address)
    {
        var result = _addressService.Delete(address);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPost("AddAdress")]
    public IActionResult AddAdress(Address address)
    {
        var result = _addressService.Add(address);
        return result.Success ? Ok(result) : BadRequest(result);
    }

    [HttpPut("UpdateAdress")]
    public IActionResult UpdateAdress(Address address)
    {
        var result = _addressService.Update(address);
        return result.Success ? Ok(result) : BadRequest(result);
    }
}
