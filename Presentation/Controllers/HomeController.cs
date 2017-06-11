using AutoMapper;
using Dto;
using Presentation.ViewModels;
using Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
       
        public HomeController(IProductService _productService,ICategoryService _categoryService)
        {
            this._productService = _productService;
            this._categoryService = _categoryService;
        }

        // GET: Home
        public ActionResult Index(string category = null)
        {
            IEnumerable<CategoryViewModel> viewModelProducts;
            IEnumerable<Category> categories;

            categories = _categoryService.GetCategories(category).ToList();

            viewModelProducts = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(viewModelProducts);
        }

        public ActionResult Filter(string category, string gadgetName)
        {
            IEnumerable<ProductViewModel> viewModelGadgets;
            IEnumerable<Product> products;

            products = _productService.GetCategoryProducts(category, gadgetName);

            viewModelGadgets = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(viewModelGadgets);
        }

        [HttpPost]
        public ActionResult Create(ProductFormViewModel newProduct)
        {
            if (newProduct != null && newProduct.File != null)
            {
                var gadget = Mapper.Map<ProductFormViewModel, Product>(newProduct);
                _productService.CreateProduct(gadget);

                string gadgetPicture = System.IO.Path.GetFileName(newProduct.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/"), gadgetPicture);
                newProduct.File.SaveAs(path);

                _productService.SaveProduct();
            }

            var category = _categoryService.GetCategory(newProduct.ProductCategory);
            return RedirectToAction("Index", new { category = category.Name });
        }

    }
}