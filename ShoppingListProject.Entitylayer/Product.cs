using System.ComponentModel.DataAnnotations;

namespace ShoppingListProject.EntityLayer
{
	public class Product
	{
		public int ProductId { get; set; }
		[Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
		public string Name { get; set; }
		[Display(Name = "Açıklama")/*, Required(ErrorMessage = "{0} Boş Geçilemez!")*/]
		public string Details { get; set; }
		[Display(Name = "Resim")]
		public string Image { get; set; }
		//[Display(Name = "Resim2")]
		//public string Image2 { get; set; }
		//[Display(Name = "Resim3")]
		//public string Image3 { get; set; }
		[Display(Name = "Fiyat")]
		public decimal Price { get; set; }
		[Display(Name = "Ürün Kodu")]
		public string? ProductCode { get; set; }
		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime? CreateDate { get; set; } = DateTime.Now;
		[Display(Name = "Kategori")]
		public int CategoryId { get; set; }
		[Display(Name = "Kategori")]
		public bool Status { get; set; }
		public virtual Category? Category { get; set; } // 1 ürünün 1 tane kategorisi olabilir (Bire Bir ilişki)
        public int UserId { get; set; } //bir ürüne bir kullanıcı sahip olabilir
    }
}
