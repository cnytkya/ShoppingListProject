using ShoppingListProject.EntityLayer;
using System.Reflection.Metadata;

namespace ShoppingListProject.BusinessLayer.Service
{
	public interface IProductService : IGenericService<Product>
	{
        List<Product> GetProductWithCategory();
        List<Product> GetProductListByUser(int id);
    }
}
