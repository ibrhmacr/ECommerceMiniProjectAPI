using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Services;

public interface ICreditCardService
{
    IDataResult<List<CreditCard>> GetCardsByUserId(int id);

    IDataResult<CreditCard> GetById(int id);

    IResult Add(CreditCard creditCard);

    IResult Update(CreditCard creditCard);

    IResult Delete(CreditCard creditCard);
}