namespace Infrastructure.Repositories
{
    #region Usings;
    using Dto;
    using Interfaces;
    using System.Linq;
    #endregion

    public class CategoryRepository : GenericRepository<Category> , ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Category GetCategoryByName(string categoryName)
        {
            var category = DbContext.Categories.Where(c => c.Name == categoryName).FirstOrDefault();

            return category;
        }

        public override void Update(Category entity)
        {
            base.Update(entity);
        }
    }
}
