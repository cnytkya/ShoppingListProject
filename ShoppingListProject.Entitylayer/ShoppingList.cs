using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListProject.EntityLayer
{
	public class ShoppingList
	{
		public int ShoppingListId { get; set; }
		public string ShoppingListName { get; set; }
		public bool IsShoppingInProgress { get; set; }
		public bool IsShoppingCompleted { get; set; }
		public int UserId { get; set; }

		// Navigation Properties
		public User User { get; set; }
		public List<ShoppingListItem> Items { get; set; }
	}
}

