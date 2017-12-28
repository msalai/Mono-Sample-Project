using System;

namespace WebShopMono.DAL.Entities
{
    public class ProductEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
