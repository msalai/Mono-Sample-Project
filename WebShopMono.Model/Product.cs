using System;
using System.ComponentModel.DataAnnotations;
using WebShopMono.Model.Common;

namespace WebShopMono.Model
{
    public class Product : IProduct
    {
        public DateTime ExpDate { get; set; }

        public int ID { get; set; }

        [Display(Name = "Product Available")]
        public bool InStock { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(1024)]
        public string Name { get; set; }

        [Display(Name = "Product Price")]
        [Range(0, 100000)]
        public decimal Price { get; set; }

    }
}
