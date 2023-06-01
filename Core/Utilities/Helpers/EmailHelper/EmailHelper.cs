using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;

namespace Core.Utilities.Helpers;

public class EmailHelper : IEmailHelper
{
    private readonly IConfiguration _config;

    public EmailHelper(IConfiguration config)
    {
        _config = config;
    }
    
    public IResult SendEmail(EmailDto emailDto)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
        email.To.Add(MailboxAddress.Parse(emailDto.To));
        email.Subject = emailDto.Subject;
        email.Body = new TextPart(TextFormat.Html) { Text = emailDto.Body };

        using var smtp = new SmtpClient();
        smtp.Connect(_config.GetSection("EmailHost").Value,587, SecureSocketOptions.StartTls);
        smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
        smtp.Send(email);
        smtp.Disconnect(true);

        return new SuccessResult("Email Sent");

    }

    public IResult ConfirmMail(User user)
    {
        throw new NotImplementedException();
    }
}