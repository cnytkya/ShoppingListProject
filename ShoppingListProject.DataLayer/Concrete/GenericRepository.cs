﻿using ShoppingListProject.DataLayer.Context;
using ShoppingListProject.DataLayer.Repositories;
using System.Linq.Expressions;

namespace ShoppingListProject.DataLayer.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(T item)
        {
            using var c = new AppDbContext();
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new AppDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new AppDbContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {

            using var c = new AppDbContext();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T item)
        {
            using var c =new AppDbContext();
            c.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            using var c = new AppDbContext();
            c.Update(item);
            c.SaveChanges();
        }
    }
}
