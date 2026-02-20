using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    /// <summary>
    /// Program to Demo about Read Only Properties
    /// </summary>
    /// 

    class Vendor
    {
        int venId;
        string vendorName;

        Vendor() { }
        public Vendor(int venId, string vendorName)
        {
            this.venId = venId;
            this.vendorName = vendorName;
        }  
        
        // Implement Read-Only Properties

        public int VenId { get { return venId; } } 
        public string VendorName { get { return vendorName; } }
    }
    internal class ReadOnlyEx
    {
        static void Main()
        {
            Vendor v1 = new Vendor(1, "Zomoto");
            //v1.VendorName = "Swiggy";
            Console.WriteLine(v1.VenId);
            Console.WriteLine(v1.VendorName);
        }
    }
}
