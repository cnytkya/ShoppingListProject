using FluentValidation;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Kullanıcı adı soyadı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi apın");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");
        }
    }
}
