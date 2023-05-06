using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class NameGenerator: INamesGenerator
    {
        public string GetName()
        {
            string[] arrayOfNames = new string[] {"Ben","Arnold","Allan","John" };
            return arrayOfNames.GetRandomArrayValue();
            
        }
    }
}
