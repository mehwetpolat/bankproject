namespace BankProject
{
    partial class frmBankSys
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnGiris = new Button();
            txtAySonuBakiye = new TextBox();
            lblAySonu = new Label();
            txtBalance = new TextBox();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            cmbHesapTuru = new ComboBox();
            txtID = new TextBox();
            btnHesapAc = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTutar = new TextBox();
            label6 = new Label();
            cmbIslemTipi = new ComboBox();
            txtNot = new TextBox();
            btnIslemYap = new Button();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lblBakiye = new Label();
            lstListe = new ListBox();
            lblMesaj = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(txtAySonuBakiye);
            groupBox1.Controls.Add(lblAySonu);
            groupBox1.Controls.Add(txtBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbHesapTuru);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(btnHesapAc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "HESAP AÇMA";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(158, 242);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(148, 34);
            btnGiris.TabIndex = 10;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtAySonuBakiye
            // 
            txtAySonuBakiye.Location = new Point(158, 186);
            txtAySonuBakiye.Name = "txtAySonuBakiye";
            txtAySonuBakiye.Size = new Size(369, 32);
            txtAySonuBakiye.TabIndex = 9;
            txtAySonuBakiye.Visible = false;
            // 
            // lblAySonu
            // 
            lblAySonu.AutoSize = true;
            lblAySonu.Location = new Point(6, 189);
            lblAySonu.Name = "lblAySonu";
            lblAySonu.Size = new Size(140, 25);
            lblAySonu.TabIndex = 8;
            lblAySonu.Text = "Ay Sonu Bakiye";
            lblAySonu.Visible = false;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(158, 148);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(369, 32);
            txtBalance.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 151);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "İlk Bakiye";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(158, 110);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(369, 32);
            txtAdSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 4;
            label3.Text = "Hesap No:";
            // 
            // cmbHesapTuru
            // 
            cmbHesapTuru.FormattingEnabled = true;
            cmbHesapTuru.Location = new Point(158, 69);
            cmbHesapTuru.Name = "cmbHesapTuru";
            cmbHesapTuru.Size = new Size(369, 33);
            cmbHesapTuru.TabIndex = 3;
            cmbHesapTuru.SelectedIndexChanged += cmbHesapTuru_SelectedIndexChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(158, 31);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(369, 32);
            txtID.TabIndex = 2;
            // 
            // btnHesapAc
            // 
            btnHesapAc.Location = new Point(312, 242);
            btnHesapAc.Name = "btnHesapAc";
            btnHesapAc.Size = new Size(215, 34);
            btnHesapAc.TabIndex = 1;
            btnHesapAc.Text = "YENİ HESAP AÇ";
            btnHesapAc.UseVisualStyleBackColor = true;
            btnHesapAc.Click += btnHesapAc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 113);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Hesap Türü:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbIslemTipi);
            groupBox2.Controls.Add(txtNot);
            groupBox2.Controls.Add(btnIslemYap);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 318);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(547, 222);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "NAKİT İŞLEMLERİ";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(158, 72);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(369, 32);
            txtTutar.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 33);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 4;
            label6.Text = "İşlem Tipi:";
            // 
            // cmbIslemTipi
            // 
            cmbIslemTipi.FormattingEnabled = true;
            cmbIslemTipi.Location = new Point(158, 30);
            cmbIslemTipi.Name = "cmbIslemTipi";
            cmbIslemTipi.Size = new Size(369, 33);
            cmbIslemTipi.TabIndex = 3;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(158, 113);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(369, 32);
            txtNot.TabIndex = 2;
            // 
            // btnIslemYap
            // 
            btnIslemYap.Location = new Point(312, 165);
            btnIslemYap.Name = "btnIslemYap";
            btnIslemYap.Size = new Size(215, 35);
            btnIslemYap.TabIndex = 1;
            btnIslemYap.Text = "İŞLEM YAP";
            btnIslemYap.UseVisualStyleBackColor = true;
            btnIslemYap.Click += btnIslemYap_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 116);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 0;
            label7.Text = "İşlem Notu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 75);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 0;
            label8.Text = "Tutar:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblBakiye);
            groupBox3.Controls.Add(lstListe);
            groupBox3.Location = new Point(567, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 528);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "HESAP HAREKETLERİ";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Location = new Point(11, 492);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(0, 25);
            lblBakiye.TabIndex = 10;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 25;
            lstListe.Location = new Point(11, 31);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(301, 454);
            lstListe.TabIndex = 10;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(17, 543);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(0, 25);
            lblMesaj.TabIndex = 6;
            // 
            // frmBankSys
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(897, 577);
            Controls.Add(lblMesaj);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "frmBankSys";
            Text = "Bank System";
            Load += frmBankSys_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBalance;
        private Label label4;
        private TextBox txtAdSoyad;
        private Label label3;
        private ComboBox cmbHesapTuru;
        private TextBox txtID;
        private Button btnHesapAc;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtTutar;
        private Label label6;
        private ComboBox cmbIslemTipi;
        private TextBox txtNot;
        private Button btnIslemYap;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private ListBox lstListe;
        private Label lblMesaj;
        private TextBox txtAySonuBakiye;
        private Label lblAySonu;
        private Label lblBakiye;
        private Button btnGiris;
    }
}
