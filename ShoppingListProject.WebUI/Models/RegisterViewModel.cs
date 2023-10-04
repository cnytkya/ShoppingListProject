using System.ComponentModel.DataAnnotations;

namespace ShoppingListProject.WebUI.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "{0} Boş Geçilemez!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        [Required(ErrorMessage = "{0} Boş Geçilemez!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }

    }
}
