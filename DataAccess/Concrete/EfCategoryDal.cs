using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfCategoryDal : EfEntityRepositoryBase<Category, ECommerceContext>, ICategoryDal
{}