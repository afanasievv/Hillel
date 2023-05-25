using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    public class StoreProduct
    {
     public int Store_Id { get; set; }
     public int Quantity { get; set; }
     public int ProductId { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public Product Product { get; set; } 
            


    }
}
