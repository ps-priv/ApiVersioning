using ProductApiWithVersions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiWithVersions.Services.Impl
{
    public class ProductService : IProductService
    {
        private IRandomProductsService _randomProductsService;

        public ProductService(IRandomProductsService randomProductsService)
        {
            _randomProductsService = randomProductsService;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _randomProductsService.GetRandomProducts();
        }

        public IEnumerable<Product> GetProducts(int numberOfProducts)
        {
            return _randomProductsService.GetRandomProducts().Take(numberOfProducts);
        }
    }
}
