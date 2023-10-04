using Microsoft.EntityFrameworkCore;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.DataLayer.Concrete;
using ShoppingListProject.DataLayer.Context;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.DataLayer.EF
{
    public class EfProductRepository : GenericRepository<Product>, IProductRepository
    {
        public List<Product> GetProductListByUser(int id)
        {
            using (var c = new AppDbContext())
            {
                return c.Products.Include(x => x.Category).Where(x => x.UserId == id).ToList();
            }
        }

        public List<Product> GetProductWithCategory()
        {
            using (var c = new AppDbContext())
            {
                return c.Products.Include(x => x.Category).ToList();
            }
        }
    }
}
