using DataLibrary.DataAccess.Interfaces;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess.Services
{
    public class VolunteerService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Volunteer> volunteerRepository;

        public VolunteerService(IUnitOfWork unitOfWork, IRepository<Volunteer> volunteerRepository)
        {
            this.unitOfWork = unitOfWork;
            this.volunteerRepository = volunteerRepository;
        }

        public void CreateVolunteer(Volunteer volunteer)
        {
            unitOfWork.BeginTransaction();

            try
            {
                volunteerRepository.Add(volunteer);
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
