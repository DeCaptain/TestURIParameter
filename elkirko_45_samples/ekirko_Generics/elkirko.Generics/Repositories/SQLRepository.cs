using System.Data.Entity;
using elkirko.Generics.Entities;
using System.Collections.Generic;
using System.Linq;

namespace elkirko.Generics.Repositories
{
    public class SQLRepository<T> : elkirko.Generics.Repositories.IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        private DbSet<T> _dbSet;

        //private readonly List<T> _items = new List<T>();
        public SQLRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int Id)
        {
            return _dbSet.Find(Id);

        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            //item.Id = _items.Count + 1;
            //_items.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
            //_items.Remove(item);

        }

        public void Save()
        {
            _dbContext.SaveChanges();
            //foreach (var item in _items)
            //{
            //    Console.WriteLine(item);

            //}

        }
    }
}
