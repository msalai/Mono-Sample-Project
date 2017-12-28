using System.Collections.Generic;

namespace WebShopMono.Model.Common
{
    public interface ICategory
    {
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        ICollection<IProduct> Products { get; set; }
    }
}
