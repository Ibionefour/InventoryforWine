using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPWinery
{
    public class Wine
    {
        // list of properties
        public int WineId;
        public string WineName;
        public int Stock;
        public double Price;
        public int SupplierID;
        public string SupplierName;

        // object constructor with passed properties as paremeters to create the wine 
        public Wine(int id, string name, int stock, double price, string supplierID)
        {
            this.WineId = id;
            this.WineName = name;
            this.Stock = stock;
            this.Price = price;
            SupplierName = supplierID;
            SupplierID = 0;
        }

        public Wine(int id, string name, int stock, double price, int supplierID)
        {
            this.WineId = id;
            this.WineName = name;
            this.Stock = stock;
            this.Price = price;
            SupplierID = supplierID;
            SupplierName = "";
        }


        // formats wine details 
        override
        public string ToString()
        {
            return String.Format(" {0,-11}\t {1,-19}\t {2,-11}\t {3,-13} ", WineId, WineName, Stock, Price);
        }
        // prints wine details
        public string print()
        {
            return

                "Wine Details" + "\n" +
                "Wine ID : " + this.WineId + "\n" +
                "Wine Name : " + this.WineName + "\n" +
                "Stock Available : " + this.Stock + "\n" +
                "Price : " + this.Price + "\n";
        }
    }
}
