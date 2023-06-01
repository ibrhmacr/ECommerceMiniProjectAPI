using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfAddressDal : EfEntityRepositoryBase<Address, ECommerceContext>, IAddressDal
{}