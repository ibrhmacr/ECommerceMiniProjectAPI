using Core.Utilities.Helpers;
using Entities.DTOs;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : Controller
{
    private IEmailHelper _emailHelper;

    public EmailController(IEmailHelper emailHelper)
    {
        _emailHelper = emailHelper;
    }

    [HttpPost("sendEmail")]
    public IActionResult SendEmail(EmailDto emailDto)
    {
        var result = _emailHelper.SendEmail(emailDto);
        return (result.Success) ? Ok(result.Message) : BadRequest();
    }
}