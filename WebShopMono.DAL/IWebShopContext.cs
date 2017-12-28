using System.Data.Entity;

namespace WebShopMono.DAL
{
    public interface IWebShopContext
    {
        IDbSet<T> Set<T>() where T : class;
        int SaveChanges();
    }
}
