using DataLibrary.DataAccess.Interfaces;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess.Services
{
    public class MilitaryUnitService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<MilitaryUnit> militaryUnitRepository;

        public MilitaryUnitService(IUnitOfWork unitOfWork, IRepository<MilitaryUnit> militaryUnitRepository)
        {
            this.unitOfWork = unitOfWork;
            this.militaryUnitRepository = militaryUnitRepository;
        }

        public void CreateVolunteer(MilitaryUnit milUnit)
        {
            unitOfWork.BeginTransaction();

            try
            {
                militaryUnitRepository.Add(milUnit);
                unitOfWork.SaveChanges();
                unitOfWork.Commit();
            }
            catch
            {
                unitOfWork.RollBack();
                throw;
            }
        }
    }
}
