using System;

namespace WebShopMono.Model.Common
{
    public interface IProduct
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        bool InStock { get; set; }
        DateTime ExpDate { get; set; }
    }
}
