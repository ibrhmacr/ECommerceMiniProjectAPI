using Business.Constant;
using Business.Services;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.Extensions.Logging;

namespace Business.Managers;

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public IDataResult<List<Category>> GetCategories()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
    }

    public IDataResult<Category> GetCategoryById(int id)
    {
        return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == id));
    }

    public IResult Add(Category category)
    {
        _categoryDal.Add(category);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Update(Category category)
    {
        _categoryDal.Update(category);
        return new SuccessResult(Messages.CategoryUpdated);
    }

    public IResult Delete(Category category)
    {
        _categoryDal.Delete(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }
}