using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class LineOfCredit : BankAccount, IMonthEndPerform
    {
        public LineOfCredit(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public void PerformMonthEndTransaction()
        {
            // bakiye ay sonu eksiye düştüğünde faizi uygular
            if(Balance < 0)
            {
                decimal interest = Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Hesaptan Aylık Faiz Gideri Alındı");

            }
        }
    }
}
