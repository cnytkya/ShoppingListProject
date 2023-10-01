using ShoppingListProject.DataLayer.Repositories;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.DataLayer.Abstract
{
	public interface IShoppingListRepository : IGenericRepository<ShoppingList>
	{
	}
}
