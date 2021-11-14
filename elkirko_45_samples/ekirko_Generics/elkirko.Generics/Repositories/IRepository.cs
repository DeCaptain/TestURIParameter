using System;
using System.Collections.Generic;
namespace elkirko.Generics.Repositories
{
    public interface IRepository<T> : IReadRepository <T>
     where T : elkirko.Generics.Entities.IEntity
    {
      
        void Add(T item);       
        void Remove(T item);
        void Save();
    }

    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);

    }
}
