namespace Infrastructure.Interfaces
{
    #region Usings
    using Dto;
    #endregion

    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}
