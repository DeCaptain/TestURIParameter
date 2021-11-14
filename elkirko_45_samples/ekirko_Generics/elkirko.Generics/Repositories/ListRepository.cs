using System;
using System.Collections.Generic;
using elkirko.Generics.Entities;
using System.Linq;


namespace elkirko.Generics.Repositories
{
    public class ListRepository<T> : IRepository<T>  where T: IEntity 
    {      
        
        private  readonly List<T> _items = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }

        public T GetById(int Id)
        {
            return _items.Find(item => item.Id == Id);
            
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);

        }

        public void Save()
        {
            //everything is saved already in the List<T>
            
        }
    }

    

  }
