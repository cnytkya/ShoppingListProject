using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.EntityLayer;
using System.Reflection.Metadata;

namespace ShoppingListProject.BusinessLayer.Manager
{
    public class ProductManager : IProductService
	{
		IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product t)
        {
            _productRepository.Insert(t);
        }

        public void Delete(Product t)
        {
            _productRepository.Delete(t);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetList()
        {
            return _productRepository.GetListAll();
        }

        public List<Product> GetProductById(int id)
        {
            return _productRepository.GetListAll(x => x.ProductId == id);
        }

        public List<Product> GetProductListByUser(int id)
        {
            return _productRepository.GetListAll(x=>x.UserId ==id);
        }

        public List<Product> GetProductWithCategory()
        {
            return _productRepository.GetProductWithCategory();
        }

        public void Update(Product t)
        {
            _productRepository.Update(t);
        }
    }
}
