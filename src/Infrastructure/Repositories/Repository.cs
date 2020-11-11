using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext _context;

        public Repository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public List<T> GetAll()
        {
            try
            {
                return _context.Set<T>().ToList();
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(T)} could not be fetched");
            }
        }

        public T Get(int id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(T)} could not be fetched");
            }
        }

        public T Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }

            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Update)} entity must not be null");
            }

            try
            {
                _context.Update(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }

        public T Delete(T entity)
        {
            try
            {
                _context.Remove(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be deleted");
            }
        }
    }
}
