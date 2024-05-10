using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class GiftCardAccount : BankAccount, IMonthEndPerform
    {
        private decimal _monthlyDeposit = 0m;


        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
        {
            _monthlyDeposit = monthlyDeposit;
        }

        public void PerformMonthEndTransaction()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Aylık Ekstra Yatırma İşlemi Yapıldı");
            }
        }
    }
}
