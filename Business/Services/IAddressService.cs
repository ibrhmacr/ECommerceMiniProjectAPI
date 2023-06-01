using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Services;

public interface IAddressService
{
    IDataResult<List<Address>> GetAll();

    IDataResult<Address> GetById(int id);

    IResult Add(Address address);

    IResult Update(Address address);

    IResult Delete(Address address);
}