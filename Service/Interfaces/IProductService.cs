namespace Service.Interfaces
{
    #region Usings
    using Dto;
    using System.Collections.Generic;

    #endregion
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetCategoryProducts(string categoryName, string productName = null);
        Product GetProduct(int id);
        void CreateProduct(Product product);
        void SaveProduct();
    }
}
