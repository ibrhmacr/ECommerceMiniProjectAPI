using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
{}