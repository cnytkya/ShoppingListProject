using ShoppingListProject.DataLayer.Repositories;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.DataLayer.Abstract
{
	public interface IProductRepository : IGenericRepository<Product>
	{
        List<Product> GetProductWithCategory();
        List<Product> GetProductListByUser(int id);
    }
}
