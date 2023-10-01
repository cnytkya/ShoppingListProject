using System.ComponentModel.DataAnnotations;

namespace ShoppingListProject.EntityLayer
{
	public class Category
	{
		public int CategoryId { get; set; }
		[Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
		public string Name { get; set; }

		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime? CreateDate { get; set; } = DateTime.Now;
		public ICollection<Product> Products { get; set; } // 1 kategorinin 1 den çok ürünü olabilir (Bire çok ilişki)
														  
	}
}
