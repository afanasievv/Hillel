using DataLibrary.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly VolunteerHeadquatersDbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository(VolunteerHeadquatersDbContext dbContext, DbSet<T> dbSet)
        {
            this.dbContext = dbContext;
            this.dbSet = dbSet;
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
