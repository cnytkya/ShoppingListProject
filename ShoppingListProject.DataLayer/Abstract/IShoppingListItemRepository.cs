using ShoppingListProject.DataLayer.Repositories;
using ShoppingListProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListProject.DataLayer.Abstract
{
	public interface IShoppingListItemRepository : IGenericRepository<ShoppingListItem>
	{
	}
}
