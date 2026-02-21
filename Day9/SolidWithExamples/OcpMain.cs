using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class OcpMain
    {
        public void showInfo(IElectricity electricity)
        {
            Console.WriteLine(electricity.Payment(1873.33));
        }

       static void Main()
       {
            OcpMain ocpMain = new OcpMain();
            NetBanking netBanking = new NetBanking();
            ocpMain.showInfo(netBanking);

            CreditCard card = new CreditCard();
            ocpMain.showInfo(card);

            DebitCard debitCard = new DebitCard();
            ocpMain.showInfo(debitCard);

            PhonePe phone = new PhonePe();
            ocpMain.showInfo(phone);
       }
    }
}
