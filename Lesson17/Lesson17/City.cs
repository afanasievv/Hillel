using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    public class City
    {   
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; } = 0;
        public int YearOfFoundation { get; set; }
        public bool IsCapital { get; set; }
        
    }
}
