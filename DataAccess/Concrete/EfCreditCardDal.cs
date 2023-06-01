using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfCreditCardDal : EfEntityRepositoryBase<CreditCard, ECommerceContext>, ICreditCardDal
{}