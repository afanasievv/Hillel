using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoreNetworkId { get; set; }
        public StoreNetwork StoreNetwork { get; set; }
        public ICollection<StoreProduct> StoreProduct { get; set; }
        
    }
}
