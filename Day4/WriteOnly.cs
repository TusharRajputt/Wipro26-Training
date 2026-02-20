using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    class Customer
    {
        private int custId;
        private string custName;
        private double billAmount;

        public int CustId { set { custId = value; } }
        public string CustName { set { custName = value; } }
        public double BillAmount { set { billAmount = value; } }

        public override string ToString()
        {
            return $"Customer Id {custId} Customer Name {custName} Bill Amount {billAmount}";
        }
    }
    internal class WriteOnly
    {
        static void Main()
        {
            Customer customer1 = new Customer();
            customer1.CustId = 1;
            customer1.CustName = "Aryan";
            customer1.BillAmount = 87773.23;

            //Console.WriteLine(customer1.CustName);
            Console.WriteLine(customer1);
        }
    }
}