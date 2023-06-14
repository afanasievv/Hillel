using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Lesson16
{
    public class StoreNetwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Store> Stores { get; set; }
    }
}
