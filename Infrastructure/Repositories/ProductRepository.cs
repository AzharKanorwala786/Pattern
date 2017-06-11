namespace Infrastructure.Repositories
{
    #region Usings;
    using Dto;
    using Interfaces;
    #endregion

    public class ProductRepository : GenericRepository<Product> , IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
