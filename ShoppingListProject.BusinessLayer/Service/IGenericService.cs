using System.Collections.Generic;

namespace ShoppingListProject.BusinessLayer.Service
{
    public interface IGenericService<T> where T : class
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);

        List<T> GetList();
        T GetById(int id);
    }
}
