using System;
using System.Collections.Generic;
namespace elkirko.Generics.Repositories
{
    public interface IRepository<T>
     where T : elkirko.Generics.Entities.IEntity
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        T GetById(int Id);
        void Remove(T item);
        void Save();
    }
}
