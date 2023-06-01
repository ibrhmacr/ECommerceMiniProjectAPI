using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Core.Utilities.Helpers;

public interface IEmailHelper
{
    IResult SendEmail(EmailDto emailDto);

    IResult ConfirmMail(User user);
}