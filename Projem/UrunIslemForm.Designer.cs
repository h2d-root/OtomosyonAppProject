namespace FormApp_Core
{
    partial class UrunIslemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SilBTN = new Button();
            label5 = new Label();
            UrunModelTB = new TextBox();
            tsuLBL = new Label();
            ToplamSatilanTB = new TextBox();
            label3 = new Label();
            UrunAdiTB = new TextBox();
            label2 = new Label();
            KaydetBTN = new Button();
            YeniKayitBTN = new Button();
            UrunMarkaTB = new TextBox();
            UrunlerDGV = new DataGridView();
            label1 = new Label();
            BarkodNoTB = new TextBox();
            musteriBilgileriGB = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            UrunStokTB = new TextBox();
            label9 = new Label();
            UrunRenkTB = new TextBox();
            label4 = new Label();
            SatisFiyatTB = new TextBox();
            label7 = new Label();
            AlisFiyatiTb = new TextBox();
            GirisSayfasiBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)UrunlerDGV).BeginInit();
            musteriBilgileriGB.SuspendLayout();
            SuspendLayout();
            // 
            // SilBTN
            // 
            SilBTN.Location = new Point(674, 195);
            SilBTN.Name = "SilBTN";
            SilBTN.Size = new Size(165, 43);
            SilBTN.TabIndex = 12;
            SilBTN.Text = "Sil";
            SilBTN.UseVisualStyleBackColor = true;
            SilBTN.Click += SilBTN_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 152);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "Ürün Model";
            // 
            // UrunModelTB
            // 
            UrunModelTB.Location = new Point(13, 175);
            UrunModelTB.Name = "UrunModelTB";
            UrunModelTB.Size = new Size(169, 27);
            UrunModelTB.TabIndex = 8;
            // 
            // tsuLBL
            // 
            tsuLBL.AutoSize = true;
            tsuLBL.Location = new Point(217, 95);
            tsuLBL.Name = "tsuLBL";
            tsuLBL.Size = new Size(108, 20);
            tsuLBL.TabIndex = 7;
            tsuLBL.Text = "Toplam Satılan";
            // 
            // ToplamSatilanTB
            // 
            ToplamSatilanTB.Location = new Point(217, 118);
            ToplamSatilanTB.Name = "ToplamSatilanTB";
            ToplamSatilanTB.Size = new Size(169, 27);
            ToplamSatilanTB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 33);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Ürün Adı";
            // 
            // UrunAdiTB
            // 
            UrunAdiTB.Location = new Point(217, 56);
            UrunAdiTB.Name = "UrunAdiTB";
            UrunAdiTB.Size = new Size(169, 27);
            UrunAdiTB.TabIndex = 4;
            UrunAdiTB.TextChanged += UrunAdiTB_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 95);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Ürün Marka";
            // 
            // KaydetBTN
            // 
            KaydetBTN.Location = new Point(674, 131);
            KaydetBTN.Name = "KaydetBTN";
            KaydetBTN.Size = new Size(165, 43);
            KaydetBTN.TabIndex = 13;
            KaydetBTN.Text = "Bilgileri Kaydet";
            KaydetBTN.UseVisualStyleBackColor = true;
            KaydetBTN.Click += KaydetBTN_Click;
            // 
            // YeniKayitBTN
            // 
            YeniKayitBTN.Location = new Point(674, 65);
            YeniKayitBTN.Name = "YeniKayitBTN";
            YeniKayitBTN.Size = new Size(165, 43);
            YeniKayitBTN.TabIndex = 14;
            YeniKayitBTN.Text = "Yeni Kayıt Oluştur";
            YeniKayitBTN.UseVisualStyleBackColor = true;
            YeniKayitBTN.Click += YeniKayitBTN_Click;
            // 
            // UrunMarkaTB
            // 
            UrunMarkaTB.Location = new Point(13, 118);
            UrunMarkaTB.Name = "UrunMarkaTB";
            UrunMarkaTB.Size = new Size(169, 27);
            UrunMarkaTB.TabIndex = 2;
            // 
            // UrunlerDGV
            // 
            UrunlerDGV.BackgroundColor = Color.SeaShell;
            UrunlerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UrunlerDGV.Location = new Point(30, 244);
            UrunlerDGV.Name = "UrunlerDGV";
            UrunlerDGV.RowHeadersWidth = 51;
            UrunlerDGV.RowTemplate.Height = 29;
            UrunlerDGV.Size = new Size(594, 247);
            UrunlerDGV.TabIndex = 7;
            UrunlerDGV.CellClick += UrunlerDGV_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Barkod No";
            // 
            // BarkodNoTB
            // 
            BarkodNoTB.Location = new Point(13, 56);
            BarkodNoTB.Name = "BarkodNoTB";
            BarkodNoTB.Size = new Size(169, 27);
            BarkodNoTB.TabIndex = 0;
            // 
            // musteriBilgileriGB
            // 
            musteriBilgileriGB.BackColor = Color.SeaShell;
            musteriBilgileriGB.Controls.Add(label11);
            musteriBilgileriGB.Controls.Add(label10);
            musteriBilgileriGB.Controls.Add(label8);
            musteriBilgileriGB.Controls.Add(UrunStokTB);
            musteriBilgileriGB.Controls.Add(label9);
            musteriBilgileriGB.Controls.Add(UrunRenkTB);
            musteriBilgileriGB.Controls.Add(label4);
            musteriBilgileriGB.Controls.Add(SatisFiyatTB);
            musteriBilgileriGB.Controls.Add(label7);
            musteriBilgileriGB.Controls.Add(AlisFiyatiTb);
            musteriBilgileriGB.Controls.Add(label5);
            musteriBilgileriGB.Controls.Add(UrunModelTB);
            musteriBilgileriGB.Controls.Add(tsuLBL);
            musteriBilgileriGB.Controls.Add(ToplamSatilanTB);
            musteriBilgileriGB.Controls.Add(label3);
            musteriBilgileriGB.Controls.Add(UrunAdiTB);
            musteriBilgileriGB.Controls.Add(label2);
            musteriBilgileriGB.Controls.Add(UrunMarkaTB);
            musteriBilgileriGB.Controls.Add(label1);
            musteriBilgileriGB.Controls.Add(BarkodNoTB);
            musteriBilgileriGB.FlatStyle = FlatStyle.Popup;
            musteriBilgileriGB.Location = new Point(30, 12);
            musteriBilgileriGB.Name = "musteriBilgileriGB";
            musteriBilgileriGB.Size = new Size(594, 226);
            musteriBilgileriGB.TabIndex = 6;
            musteriBilgileriGB.TabStop = false;
            musteriBilgileriGB.Text = "Ürün Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(564, 182);
            label11.Name = "label11";
            label11.Size = new Size(24, 20);
            label11.TabIndex = 21;
            label11.Text = "TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(564, 125);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 20;
            label10.Text = "TL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 152);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 19;
            label8.Text = "Stok";
            // 
            // UrunStokTB
            // 
            UrunStokTB.Location = new Point(217, 175);
            UrunStokTB.Name = "UrunStokTB";
            UrunStokTB.Size = new Size(169, 27);
            UrunStokTB.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(419, 33);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 17;
            label9.Text = "Renk";
            // 
            // UrunRenkTB
            // 
            UrunRenkTB.Location = new Point(419, 56);
            UrunRenkTB.Name = "UrunRenkTB";
            UrunRenkTB.Size = new Size(169, 27);
            UrunRenkTB.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 152);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 15;
            label4.Text = "Satış Fiyatı";
            // 
            // SatisFiyatTB
            // 
            SatisFiyatTB.Location = new Point(419, 175);
            SatisFiyatTB.Name = "SatisFiyatTB";
            SatisFiyatTB.Size = new Size(139, 27);
            SatisFiyatTB.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(419, 95);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 13;
            label7.Text = "Alış Fiyatı";
            // 
            // AlisFiyatiTb
            // 
            AlisFiyatiTb.Location = new Point(419, 118);
            AlisFiyatiTb.Name = "AlisFiyatiTb";
            AlisFiyatiTb.Size = new Size(139, 27);
            AlisFiyatiTb.TabIndex = 12;
            // 
            // GirisSayfasiBTN
            // 
            GirisSayfasiBTN.Location = new Point(674, 12);
            GirisSayfasiBTN.Name = "GirisSayfasiBTN";
            GirisSayfasiBTN.Size = new Size(165, 29);
            GirisSayfasiBTN.TabIndex = 16;
            GirisSayfasiBTN.Text = "Giriş Ekranına dön";
            GirisSayfasiBTN.UseVisualStyleBackColor = true;
            GirisSayfasiBTN.Click += GirisSayfasiBTN_Click;
            // 
            // UrunIslemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 503);
            Controls.Add(GirisSayfasiBTN);
            Controls.Add(SilBTN);
            Controls.Add(KaydetBTN);
            Controls.Add(YeniKayitBTN);
            Controls.Add(UrunlerDGV);
            Controls.Add(musteriBilgileriGB);
            Name = "UrunIslemForm";
            Text = "Ürün İşlem Form";
            Load += UrunIslemForm_Load;
            ((System.ComponentModel.ISupportInitialize)UrunlerDGV).EndInit();
            musteriBilgileriGB.ResumeLayout(false);
            musteriBilgileriGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SilBTN;
        private Label label6;
        private Label label5;
        private TextBox UrunModelTB;
        private Label tsuLBL;
        private TextBox ToplamSatilanTB;
        private Label label3;
        private TextBox UrunAdiTB;
        private Label label2;
        private Button KaydetBTN;
        private Button YeniKayitBTN;
        private TextBox UrunMarkaTB;
        private TextBox MusteriEpostaTb;
        private DataGridView UrunlerDGV;
        private Label label1;
        private TextBox BarkodNoTB;
        private GroupBox musteriBilgileriGB;
        private Label label4;
        private TextBox SatisFiyatTB;
        private Label label7;
        private TextBox AlisFiyatiTb;
        private Label label8;
        private TextBox UrunStokTB;
        private Label label9;
        private TextBox UrunRenkTB;
        private Button GirisSayfasiBTN;
        private Label label11;
        private Label label10;
    }
}