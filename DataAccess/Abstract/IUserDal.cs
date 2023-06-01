using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract;

public interface IUserDal : IEntityRepositoryBase<User>
{
    List<OperationClaim> GetClaims(User user);
}