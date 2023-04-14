using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Lottery
    {
        public HashSet<int> Emit(int countOfUniqueNumbers)
        {  Random random = new Random();

           HashSet<int> listOfUniqueNumbers = new HashSet<int>();
           while(listOfUniqueNumbers.Count<6)
            {                
                listOfUniqueNumbers.Add(random.Next(1,countOfUniqueNumbers+1));
            }
           return listOfUniqueNumbers;
        }
    }
}
