using System.Collections.Generic;

namespace WebShopMono.DAL.Entities
{
    public class CategoryEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}
