using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Common
{
    public class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return "Server=.; Database=Northwind; UID=sa; PWD=1234";
            }
        }
    }
}
