using System.Linq;

namespace WebShopMono.Repository.Common
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
