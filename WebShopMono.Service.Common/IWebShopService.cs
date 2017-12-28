using System.Linq;
using WebShopMono.Model.Common;

namespace WebShopMono.Service.Common
{
    public interface IWebShopService
    {
        void AddProduct(IProduct p);
        IQueryable<IProduct> GetAllAvailableProducts();
    }
}
