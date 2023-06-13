using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess.Interfaces;
using DataLibrary.Models;
using Ninject;
using Ninject.Modules;

namespace DataLibrary.DataAccess
{
    public class VHNinjectModule
    {
        //public override void Load()
        //{
        public static void ConfigureDependencies(IKernel kernel)
        {
            kernel.Bind<IRepository<Volunteer>>().To<Repository<Volunteer>>();
            kernel.Bind<IRepository<MilitaryUnit>>().To<Repository<MilitaryUnit>>();
            kernel.Bind<IRepository<Request>>().To<Repository<Request>>();
            kernel.Bind<IRepository<Organization>>().To<Repository<Organization>>();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

            //}

        }
    }
}
