using System.Collections.Generic;
using System.Linq;
using WebShopMono.DAL.Entities;
using WebShopMono.Model;
using WebShopMono.Model.Common;
using WebShopMono.Repository.Common;
using WebShopMono.Service.Common;

namespace WebShopMono.Service
{
    public class WebShopProductService : IWebShopService
    {
        protected IGenericRepository<ProductEntity> ProductRepository { get; private set; }

        public WebShopProductService(IGenericRepository<ProductEntity> repository)
        {
            this.ProductRepository = repository;
        }

        public void AddProduct(IProduct p)
        {
            var x = AutoMapper.Mapper.Map<ProductEntity>(p);

            ProductRepository.Insert(x);
        }

        public IQueryable<IProduct> GetAllAvailableProducts()
        {
            var xx = (AutoMapper.Mapper.Map<List<Product>>(ProductRepository.Table.Where(p => p.InStock == true)));

            return xx.AsQueryable();
        }

    }
}
