using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Entity
{
    public class Category
    {
        // Category'e ait kullandığım tüm property'lerim bu kısımda yer alıyor.

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
