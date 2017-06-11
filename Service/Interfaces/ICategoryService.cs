namespace Service.Interfaces
{
    #region Usings;
    using Dto;
    using System.Collections.Generic;
    #endregion

    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories(string name = null);
        Category GetCategory(int id);
        Category GetCategory(string name);
        void CreateCategory(Category category);
        void SaveCategory();
    }
}
