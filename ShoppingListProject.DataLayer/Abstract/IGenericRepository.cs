using System.Linq.Expressions;

namespace ShoppingListProject.DataLayer.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetListAll();
        T GetById(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
