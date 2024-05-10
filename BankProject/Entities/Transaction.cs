using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class Transaction
    {
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Note = note;
        }


        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }


    }
}
