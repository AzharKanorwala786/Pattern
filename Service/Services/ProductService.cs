namespace Service.Services
{
    #region Usings
    using Interfaces;
    using System.Collections.Generic;
    using Dto;
    using Infrastructure.Interfaces;
    using System.Linq;
    #endregion

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository _productRepository, ICategoryRepository _categoryRepository, IUnitOfWork _unitOfWork)
        {
            this._productRepository = _productRepository;
            this._categoryRepository = _categoryRepository;
            this._unitOfWork = _unitOfWork;
        }

        public void CreateProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public Product GetProduct(int id)
        {
            var product = _productRepository.GetById(id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _productRepository.GetAll();
            return products;
        }

        public IEnumerable<Product> GetCategoryProducts(string categoryName, string productName = null)
        {
            var category = _categoryRepository.GetCategoryByName(categoryName);
            return category.Products.Where(c => c.Name.ToLower().Contains(productName.ToLower().Trim()));
        }

        public void SaveProduct()
        {
            _unitOfWork.Commit();
        }
    }
}
