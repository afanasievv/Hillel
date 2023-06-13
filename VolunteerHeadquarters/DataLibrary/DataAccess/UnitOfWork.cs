using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess.Interfaces;

namespace DataLibrary.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VolunteerHeadquatersDbContext dbContext;

        public UnitOfWork(VolunteerHeadquatersDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        
        public void BeginTransaction()
        {
            dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            dbContext.SaveChanges();
            dbContext.Database.CurrentTransaction?.Commit();
            
        }

        public void RollBack()
        {
            dbContext.Database.CurrentTransaction?.Rollback();
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}
