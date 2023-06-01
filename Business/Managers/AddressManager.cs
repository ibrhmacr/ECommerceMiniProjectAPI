using Business.Constant;
using Business.Services;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Managers;

public class AddressManager : IAddressService
{
    private IAddressDal _addressDal;

    public AddressManager(IAddressDal addressDal)
    {
        _addressDal = addressDal;
    }

    public IDataResult<List<Address>> GetAll()
    {
        return new SuccessDataResult<List<Address>>(_addressDal.GetAll());
    }

    public IDataResult<Address> GetById(int id)
    {
        return new SuccessDataResult<Address>(_addressDal.Get(a => a.Id == id));
    }

    public IResult Add(Address address)
    {
        _addressDal.Add(address);
        return new SuccessResult(Messages.AddressAdded);
    }

    public IResult Update(Address address)
    {
        _addressDal.Update(address);
        return new SuccessResult(Messages.AddressUpdated);
    }

    public IResult Delete(Address address)
    {
        _addressDal.Delete(address);
        return new SuccessResult(Messages.AddressDeleted);
    }
}