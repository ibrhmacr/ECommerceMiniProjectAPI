using System.Linq.Expressions;
using Core.Entities.Abstract;

namespace Core.DataAccess;

public interface IEntityRepositoryBase<T> where T : class, IEntity, new()
{
    List<T> GetAll(Expression<Func<T, bool>> filter = null);

    T Get(Expression<Func<T, bool>> filter);

    void Add(T entity);

    void Update(T entity);

    void Delete(T entity);
}