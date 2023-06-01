using Business.Constant;
using Business.Services;
using Core.Utilities.Results;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Managers;

public class CreditCardManager : ICreditCardService
{
    private EfCreditCardDal _creditCardDal;

    public CreditCardManager(EfCreditCardDal creditCardDal)
    {
        _creditCardDal = creditCardDal;
    }

    public IDataResult<List<CreditCard>> GetCardsByUserId(int id)
    {
        return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.UserId == id));
    }

    public IDataResult<CreditCard> GetById(int id)
    {
        return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.Id == id));
    }

    public IResult Add(CreditCard creditCard)
    {
        _creditCardDal.Add(creditCard);
        return new SuccessResult(Messages.CreditCardAdded);
    }

    public IResult Update(CreditCard creditCard)
    {
        _creditCardDal.Update(creditCard);
        return new SuccessResult(Messages.CreditCardUpdated);
    }

    public IResult Delete(CreditCard creditCard)
    {
        _creditCardDal.Delete(creditCard);
        return new SuccessResult(Messages.CreditCardDeleted);
    }
}