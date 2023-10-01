using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.BusinessLayer.Manager
{
    public class ShoppingListItemManager : IShoppingListItemService
    {
        IShoppingListItemRepository _repository;

        public ShoppingListItemManager(IShoppingListItemRepository repository)
        {
            _repository = repository;
        }

        public void Add(ShoppingListItem t)
        {
            _repository.Insert(t);
        }

        public void Delete(ShoppingListItem t)
        {
            _repository.Delete(t);
        }

        public ShoppingListItem GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<ShoppingListItem> GetList()
        {
            return _repository.GetListAll();
        }

        public void Update(ShoppingListItem t)
        {
            _repository.Update(t);
        }
    }
}
