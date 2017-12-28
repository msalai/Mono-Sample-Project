using System.Data.Entity;
using WebShopMono.DAL.Entities;

namespace WebShopMono.DAL
{
    public class WebShopContext : DbContext, IWebShopContext
    {
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
        public WebShopContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
