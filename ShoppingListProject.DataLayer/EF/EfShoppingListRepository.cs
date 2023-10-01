using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.DataLayer.Concrete;
using ShoppingListProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListProject.DataLayer.EF
{
    public class EfShoppingListRepository : GenericRepository<ShoppingList>, IShoppingListRepository
    {
    }
}
