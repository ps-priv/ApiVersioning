using ProductApiWithVersions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiWithVersions.Services
{
    public interface IRandomProductsService
    {
        IEnumerable<Product> GetRandomProducts();
    }
}
