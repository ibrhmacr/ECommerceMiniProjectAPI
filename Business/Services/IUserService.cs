using Core.Entities.Concrete;

namespace Business.Services;

public interface IUserService
{
    List<OperationClaim> GetClaims(User user);

    void Add(User user);

    User GetByMail(string email);
}