using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class InterestEarningAccount : BankAccount, IMonthEndPerform
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public void PerformMonthEndTransaction()
        {
            if(Balance > 500)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "Aylık Faiz Getirisi Hesaba Yatırıldı");
            }
        }
    }
}
