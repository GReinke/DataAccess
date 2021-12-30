using System.Linq.Expressions;

namespace Library.DataAccess;

public interface IAbstractRepository<TEntity> where TEntity : class
{
    public TEntity Get(string id);

    public ICollection<TEntity> GetMany(ICollection<string> ids);

    public ICollection<TEntity> GetAll();

    public ICollection<TEntity> Filter(Expression<Func<TEntity, bool>> filterExpression);

    public TEntity Create(TEntity entity);

    public ICollection<TEntity> CreateMany(ICollection<TEntity> entity);

    public TEntity Update(TEntity entity);

    public ICollection<TEntity> UpdateMany(ICollection<TEntity> entity);

    public void Delete(TEntity entity);

    public void DeleteMany(ICollection<TEntity> entities);
}