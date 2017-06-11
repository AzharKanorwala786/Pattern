using Dto;
using Infrastructure.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductAPIController : ApiController
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductAPIController(IProductService _productService, ICategoryService _categoryService)
        {
            this._productService = _productService;
            this._categoryService = _categoryService;
        }

        //[HttpGet]
        //public IEnumerable<Product> GetAllProducts()
        //{
            
        //}
    }
}
