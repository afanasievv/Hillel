using DataLibrary.DataAccess.Interfaces;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess.Services
{
    public class RequestService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Request> requestRepository;

        public RequestService(IUnitOfWork unitOfWork, IRepository<Request> requestRepository)
        {
            this.unitOfWork = unitOfWork;
            this.requestRepository = requestRepository;
        }

        public void CreateVolunteer(Request request)
        {
            unitOfWork.BeginTransaction();

            try
            {
                requestRepository.Add(request);
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
