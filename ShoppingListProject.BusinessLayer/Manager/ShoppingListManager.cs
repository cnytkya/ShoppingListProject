using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.BusinessLayer.Manager
{
    public class ShoppingListManager : IShoppingListService
    {
        IShoppingListRepository _repo;

        public ShoppingListManager(IShoppingListRepository repo)
        {
            _repo = repo;
        }

        public void Add(ShoppingList t)
        {
            _repo.Insert(t);
        }

        public void Delete(ShoppingList t)
        {
            _repo.Delete(t);
        }

        public ShoppingList GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<ShoppingList> GetList()
        {
            return _repo.GetListAll();
        }

        public void Update(ShoppingList t)
        {
            _repo.Update(t);
        }
    }
}
