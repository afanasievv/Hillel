using DataLibrary.DataAccess.Interfaces;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess.Services
{
    public class OrganizationService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Organization> organizationRepository;

        public OrganizationService(IUnitOfWork unitOfWork, IRepository<Organization> organizationRepository)
        {
            this.unitOfWork = unitOfWork;
            this.organizationRepository = organizationRepository;
        }

        public void CreateVolunteer(Organization organization)
        {
            unitOfWork.BeginTransaction();

            try
            {
                organizationRepository.Add(organization);
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
