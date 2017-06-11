namespace Service.Services
{
    #region Usings
    using Interfaces;
    using System.Collections.Generic;
    using Dto;
    using Infrastructure.Interfaces;
    using System.Linq;
    #endregion

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository _categoryRepository, IUnitOfWork _unitOfWork)
        {
            this._categoryRepository = _categoryRepository;
            this._unitOfWork = _unitOfWork;
        }

        public void CreateCategory(Category category)
        {
            _categoryRepository.Add(category);
        }

        public IEnumerable<Category> GetCategories(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return _categoryRepository.GetAll();
            else
                return _categoryRepository.GetAll().Where(c => c.Name == name);
        }

        public Category GetCategory(string name)
        {
            var category = _categoryRepository.GetCategoryByName(name);
            return category;
        }

        public Category GetCategory(int id)
        {
            var category = _categoryRepository.GetById(id);
            return category;
        }

        public void SaveCategory()
        {
            _unitOfWork.Commit();
        }
    }
}
