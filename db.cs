using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall_Shoprite
{
    internal class db
    {
        private string con;
        public string connection()
        {
            con = @"Data Source=DESKTOP-CI6FKTB;Initial Catalog=POS_Shoprite;Integrated Security=True";
            return con;  
        }
    }
}
