using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.EntityLayer;

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

        public void Update(Product t)
        {
            _productRepository.Update(t);
        }
    }
}
