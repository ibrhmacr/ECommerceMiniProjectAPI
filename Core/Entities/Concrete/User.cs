using Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;


namespace Core.Entities.Concrete;

public class User : IdentityUser,IEntity 
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public byte[] PasswordSalt { get; set; }

    public byte[] PasswordHash { get; set; }

    public bool Status { get; set; }
}