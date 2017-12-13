using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Entity
{
   public class Product
    {
        // Product'a ait kullandığım tüm property'lerim bu kısımda yer alıyor.
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        
        public override string ToString()
        {
            return ProductName;
        }

    }
}
