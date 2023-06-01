using Business.Constant;
using Business.Services;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Managers;

public class ProductManager : IProductService
{
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public IDataResult<List<Product>> GetProductsByCategoryId(int id)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
    }

    public IDataResult<List<Product>> GetProductsByUserId(int id)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UserId == id));
    }

    public IDataResult<Product> GetById(int id)
    {
        var result = _productDal.GetAll().Count;

        return id > result
            ? new ErrorDataResult<Product>(Messages.InvalidProductId)
            : new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
    }

    public IResult Add(Product product)
    {
        _productDal.Add(product);
        return new SuccessResult(Messages.ProductAdded);
    }

    public IResult Update(Product product)
    {
        _productDal.Update(product);
        return new SuccessResult(Messages.ProductUpdated);
    }

    public IResult Delete(Product product)
    {
        _productDal.Delete(product);
        return new SuccessResult(Messages.ProductDeleted);
    }
}