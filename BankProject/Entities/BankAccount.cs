using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Entities
{
    public class BankAccount
    {
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "İlk Para Yatırma İşlemi");
        }



        public string Number { get; set; } = Guid.NewGuid().ToString();
        public string Owner { get; set; }
        public decimal Balance 
        {

            // yatırma ve çekme işlemleri sonucundaki bakiyeyi verir.
            get
            {
                decimal blnc = 0;
                foreach (var item in allTransactions)
                {
                    blnc += item.Amount;
                }
                return blnc;
            }
        }







        // tüm yatırma ve çekme işlemleri burada tutulacak
        private List<Transaction> allTransactions = new List<Transaction>();



        // para yatırma hareketleri
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            { 
                throw new ArgumentOutOfRangeException(nameof(amount), "Yatırılan Tutar Pozitif Olmalıdır");
            }

            // para yatırma işlemini kaydet
            Transaction trn = new Transaction(amount, date, note);
            allTransactions.Add(trn);
        }



        // para çekme hareketleri
        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Çekilen Tutar Pozitif Olmalıdır");
            }

            if(amount > Balance)// ***
            {
                throw new InvalidOperationException("Çekilmek İstenen Tutar Mevcut Bakiyeden Fazla Olamaz");
            }

            // para çekme işlemini kaydet
            Transaction wthdrwl = new Transaction(-amount, date, note);
            allTransactions.Add(wthdrwl);
        }





        // çek yatır işlem geçmişi
        public string GetAccountHistory()
        {
            string islmYazisi = "";
            int sayac = 1;
           

            foreach (var item in allTransactions)
            {
                string islemTipi = (item.Amount < 0) ? "Para Çekme İşlemi" : "Para Yatırma İşlemi";
                islmYazisi = $"{sayac}.İşlem: {item.Amount} $ {islemTipi}";
                sayac++;
            }

            return islmYazisi;
        }
    }
}
