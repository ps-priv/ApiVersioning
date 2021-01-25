using ProductApiWithVersions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiWithVersions.Services.Impl
{
    public class RandomProductsService : IRandomProductsService
    {
        private IEnumerable<Product> _products;

        public RandomProductsService()
        {
            _products = GenerateProducts();
        }

        public IEnumerable<Product> GetRandomProducts()
        {
            return _products;
        }

        private IEnumerable<Product> GenerateProducts()
        {
            var rnd = new Random((int)DateTime.Now.Ticks);
            var list = new List<Product>();

            for (int i = 1; i <= 40; i++)
            {
                list.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Ean = Convert.ToString(DateTime.Now.Ticks),
                    Price = Math.Round(rnd.NextDouble() * 100, 2)
                });
            }

            return list;
        }
    }
}
