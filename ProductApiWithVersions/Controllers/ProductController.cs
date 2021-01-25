using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApiWithVersions.Models;
using ProductApiWithVersions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiWithVersions.Controllers
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0")]
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Zwraca listę produktów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productService.GetProducts();
        }

        /// <summary>
        /// Zwraca listę produktów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("2.0")]
        public IEnumerable<Product> GetAllProductsV2()
        {
            return _productService.GetProducts(10);
        }
    }
}
