using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public abstract class FireArm
    {
        internal bool isLoaded;
        public abstract void Reload();

        public virtual void FireArmClean()
        {
            Console.WriteLine("Чищу зброю!");
        }
        public abstract void Shoot();

    }
}
