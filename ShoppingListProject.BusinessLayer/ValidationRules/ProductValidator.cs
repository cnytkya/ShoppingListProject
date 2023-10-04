using FluentValidation;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori ID boş geçilemez");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır");
        }
    }
}
