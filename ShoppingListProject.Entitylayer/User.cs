using ShoppingListProject.Entitylayer;
using System.ComponentModel.DataAnnotations;

namespace ShoppingListProject.EntityLayer
{
	public class User
	{
		public int UserId { get; set; }
		[Display(Name = "Ad"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
		public string FirstName { get; set; }
		[Display(Name = "Soyad"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
		public string LastName { get; set; }
		[Display(Name = "Email"), Required(ErrorMessage = "{0} Boş Geçilemez!")]
		public string Email { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "{0} Boş Geçilemez!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrarı")]
        [Required(ErrorMessage = "{0} Boş Geçilemez!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
		[Display(Name = "Aktif?")]
		public bool IsActive { get; set; }
		[Display(Name = "Admin?")]
		public bool IsAdmin { get; set; }
		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)] // ScaffoldColumn(false) sayfa oluştururken ekranda bu alan oluşmasın diye
		public DateTime? CreateDate { get; set; } = DateTime.Now;

		public bool IsPasswordValid()
		{
			// Şifre en az 8 karakter olmalı ve büyük harf, küçük harf ve rakam içermelidir.
			return Password.Length >= 8 && Password.Any(char.IsUpper) && Password.Any(char.IsLower) && Password.Any(char.IsDigit);
		}

		// Navigation Property
		public List<ShoppingList> ShoppingLists { get; set; }

        //public virtual ICollection<Message> Sender { get; set; }
        //public virtual ICollection<Message> Receiver { get; set; }
    }
}

