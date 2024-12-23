using BankProject.Entities;

namespace BankProject
{
    public partial class frmBankSys : Form
    {
        public frmBankSys()
        {
            InitializeComponent();
        }

        private void frmBankSys_Load(object sender, EventArgs e)
        {
            #region Aciklama
            /*
            InterestEarningAccount (Faiz Getiri Hesabi): mevcut bakiye 500dolardan fazla ise her ay sonu %5 faiz getirisi saglanir
            LineOfCreditAccount (Kredi Limit Hesabi): eksi bakiyeye düsebilir ay sonu eksiye düþerse %7 faiz gideri uygulanir
            GiftCardAccount (Hediye Karti Hesabi): Her ay sonu istenirse bir miktar para yatirma islemi yapilabilir
             */
            #endregion



            CombolariDoldur();
        }



        private void CombolariDoldur()
        {
            // islem tipini cmbye doldur
            cmbIslemTipi.Items.AddRange(Enum.GetNames(typeof(IslemTipi)));


            // hesap tiplerini cmbye doldur
            cmbHesapTuru.Items.AddRange(Enum.GetNames(typeof(HesapTurleri)));
        }




        // bir önceki hesaplarýn verilerini tutabiliyor sadece bir adim daha eskiye gittiginde veriler gidiyor
        List<string> acData = new List<string>();
        List<string> acTransaction = new List<string>();


        BankAccount hesap;

        private void btnHesapAc_Click(object sender, EventArgs e)
        {


            try
            {
                if (lstListe.Items.Count != 0)
                {
                    foreach (var item in lstListe.Items)
                    {
                        acTransaction.Add(item.ToString());
                    }
                }



                lstListe.Items.Clear();

                string owner = txtAdSoyad.Text;
                decimal balance = Convert.ToDecimal(txtBalance.Text);
                int secilenHesap = cmbHesapTuru.SelectedIndex;






                // interest ac
                if (secilenHesap == 0)
                {
                    var InterestEarning = new InterestEarningAccount(owner, balance);
                    hesap = InterestEarning;
                }
                // line ac
                else if (secilenHesap == 1)
                {
                    var LineOfCredit = new LineOfCredit(owner, balance);
                    hesap = LineOfCredit;
                }
                // gift ac
                else
                {
                    decimal endBalance = Convert.ToDecimal(txtAySonuBakiye.Text);
                    var GiftCard = new GiftCardAccount(owner, balance, endBalance);
                    hesap = GiftCard;
                }

                txtID.Text = hesap.Number;
                lblMesaj.Text = "Hesap Baþarýyla Oluþturuldu";


                BakiyeGuncelle();



                
                acData.Add(txtID.Text + " " + owner + " " + secilenHesap + " " + lblBakiye.Text);
            }
            catch (Exception HATA)
            {
                lblMesaj.Text = HATA.Message;
            }


        }




        // var olan hesaba girme
        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (var item in acData)
            {
                if (item.Contains(txtAdSoyad.Text))
                {
                    string[] metin = item.Split(' ');

                    txtID.Text = metin[0];
                    txtBalance.Text = metin[3];
                    cmbHesapTuru.SelectedIndex = int.Parse(metin[2]);

                    lstListe.Items.Clear();


                    foreach (string c in acTransaction)
                    {
                        lstListe.Items.Add(c);
                    }

                    break;
                }

            }
        }




        private void BakiyeGuncelle()
        {
            if (hesap != null)
            {
                lstListe.Items.Add(hesap.GetAccountHistory());
                lblBakiye.Text = hesap.Balance.ToString();
            }
        }





        // ay sonu bakiye sadece gift hesabýnda olduðu için gizle göster iþlemi
        private void cmbHesapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool cvp = (cmbHesapTuru.SelectedIndex == 2) ? true : false;

            lblAySonu.Visible = cvp;
            txtAySonuBakiye.Visible = cvp;
        }







        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            int secilenIslemTipi = cmbIslemTipi.SelectedIndex;

            // para cekme 0, para yatýrma 1

            decimal amount = Convert.ToDecimal(txtTutar.Text);
            string note = txtNot.Text;


            if (secilenIslemTipi == 0)
            {
                hesap.MakeWithDrawal(amount, DateTime.Now, note);

            }
            else
            {
                hesap.MakeDeposit(amount, DateTime.Now, note);
            }

            BakiyeGuncelle();
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
