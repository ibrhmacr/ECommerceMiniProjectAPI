using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Services;

public interface ICategoryService
{
    IDataResult<List<Category>> GetCategories();

    IDataResult<Category> GetCategoryById(int id);

    IResult Add(Category category);

    IResult Update(Category category);

    IResult Delete(Category category);
}