namespace ShoppingListProject.EntityLayer
{
	public class ShoppingListItem
	{
		public int ShoppingListItemId { get; set; }
		public int ProductId { get; set; }
		public int ShoppingListId { get; set; }
		public int Quantity { get; set; }
		public string Note { get; set; }

		// Navigation Properties
		public Product Product { get; set; }
		public ShoppingList ShoppingList { get; set; }
	}
}
