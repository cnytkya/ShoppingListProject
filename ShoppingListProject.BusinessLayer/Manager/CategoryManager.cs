using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.BusinessLayer.Manager
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category t)
        {
            _categoryRepository.Insert(t);
        }

        public void Delete(Category t)
        {
            _categoryRepository.Delete(t);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryRepository.GetListAll();
        }

        public void Update(Category t)
        {
            _categoryRepository.Update(t);
        }
    }
}
