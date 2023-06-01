using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Services;

public interface IProductService
{
    IDataResult<List<Product>> GetProductsByCategoryId(int id);

    IDataResult<List<Product>> GetProductsByUserId(int id);

    IDataResult<Product> GetById(int id);

    IResult Add(Product product);

    IResult Update(Product product);

    IResult Delete(Product product);
}