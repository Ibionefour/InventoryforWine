using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPWinery
{
    public class Supplier
    {
        public int SupplierID;
        public string SuppName;
        public string Location;
        public string Email;

        public Supplier()
        {
            SupplierID = 0;
            SuppName = "";
            Location = "";
            Email = "";
        }
        public Supplier(int suppID,string name, string location, string email)
        {
            SupplierID = suppID;
            SuppName = name;
            Location = location;
            Email = email;
        }



    }
}
