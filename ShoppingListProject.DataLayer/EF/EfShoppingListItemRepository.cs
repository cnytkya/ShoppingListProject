using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.DataLayer.Concrete;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.DataLayer.EF
{
    public class EfShoppingListItemRepository : GenericRepository<ShoppingListItem>, IShoppingListItemRepository
    {
    }
}
