using System.Text;
using Business.Services;
using Core.Entities.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : Controller
{
    private IAuthService _authService;
    
    private IUserService _userService;
    

    public AuthController(IAuthService authService,IUserService userService)
    {
        _authService = authService;
        
        _userService = userService;
        
    }
    
    [HttpPost("Login")]
    public IActionResult Login(UserForLoginDto userForLoginDto)
    {
        var userToLogin = _authService.Login(userForLoginDto);
        if (!userToLogin.Success)
        {
            return BadRequest(userToLogin.Message);
        }

        var result = _authService.CreateAccessToken(userToLogin.Data);
        if (result.Success)
        {
            return Ok(result.Data);
        }

        return BadRequest(result.Message);
    }

    [HttpPost("Register")]
    public IActionResult Register(UserForRegisterDto userForRegisterDto)
    {
        var userExists = _authService.UserExists(userForRegisterDto.Email);
        if (!userExists.Success)
        {
            return BadRequest(userExists.Message);
        }

        var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
        var result = _authService.CreateAccessToken(registerResult.Data);

        if (result.Success)
        {
            return Ok(result.Data);
        }

        return BadRequest(result.Message);


    }
    
}