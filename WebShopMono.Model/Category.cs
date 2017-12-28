using System.Collections.Generic;
using WebShopMono.Model.Common;

namespace WebShopMono.Model
{
    public class Category : ICategory
    {
        public string Description { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<IProduct> Products { get; set; }

    }
}
