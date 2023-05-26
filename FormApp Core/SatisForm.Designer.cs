namespace FormApp_Core
{
    partial class SatisForm
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
            groupBox1 = new GroupBox();
            USatisTb = new TextBox();
            label3 = new Label();
            UStokTb = new TextBox();
            label2 = new Label();
            UBNoTb = new TextBox();
            label1 = new Label();
            dataGridViewUrun = new DataGridView();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            label9 = new Label();
            button1 = new Button();
            ToplamTutarTb = new TextBox();
            TaksitRB = new RadioButton();
            label7 = new Label();
            PesinRB = new RadioButton();
            AdetTb = new TextBox();
            taksitTutari = new ComboBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            MusteriAdiTb = new TextBox();
            MSoyadTb = new TextBox();
            label4 = new Label();
            MAdiTb = new TextBox();
            MNoTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridViewMusteri = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrun).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMusteri).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(USatisTb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(UStokTb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(UBNoTb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridViewUrun);
            groupBox1.Location = new Point(12, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Bilgileri";
            // 
            // USatisTb
            // 
            USatisTb.Enabled = false;
            USatisTb.Location = new Point(655, 182);
            USatisTb.Name = "USatisTb";
            USatisTb.Size = new Size(256, 27);
            USatisTb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 159);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 5;
            label3.Text = "Ürün Satış Fiyatı";
            // 
            // UStokTb
            // 
            UStokTb.Enabled = false;
            UStokTb.Location = new Point(655, 109);
            UStokTb.Name = "UStokTb";
            UStokTb.Size = new Size(256, 27);
            UStokTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 86);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 3;
            label2.Text = "Ürün Stok Adedi";
            // 
            // UBNoTb
            // 
            UBNoTb.Enabled = false;
            UBNoTb.Location = new Point(655, 46);
            UBNoTb.Name = "UBNoTb";
            UBNoTb.Size = new Size(256, 27);
            UBNoTb.TabIndex = 2;
            UBNoTb.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Barkod No";
            // 
            // dataGridViewUrun
            // 
            dataGridViewUrun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrun.Dock = DockStyle.Left;
            dataGridViewUrun.Location = new Point(3, 23);
            dataGridViewUrun.Name = "dataGridViewUrun";
            dataGridViewUrun.RowHeadersWidth = 51;
            dataGridViewUrun.RowTemplate.Height = 29;
            dataGridViewUrun.Size = new Size(646, 347);
            dataGridViewUrun.TabIndex = 0;
            dataGridViewUrun.CellClick += dataGridViewUrun_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(ToplamTutarTb);
            groupBox3.Controls.Add(TaksitRB);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(PesinRB);
            groupBox3.Controls.Add(AdetTb);
            groupBox3.Controls.Add(taksitTutari);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(935, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 748);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Satış İşlemleri";
            // 
            // button3
            // 
            button3.Location = new Point(238, 200);
            button3.Name = "button3";
            button3.Size = new Size(24, 25);
            button3.TabIndex = 13;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 200);
            button2.Name = "button2";
            button2.Size = new Size(24, 25);
            button2.TabIndex = 13;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.Location = new Point(169, 396);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 12;
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(34, 442);
            button1.Name = "button1";
            button1.Size = new Size(196, 46);
            button1.TabIndex = 11;
            button1.Text = "Satışı Tamamla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ToplamTutarTb
            // 
            ToplamTutarTb.Enabled = false;
            ToplamTutarTb.Location = new Point(6, 271);
            ToplamTutarTb.Name = "ToplamTutarTb";
            ToplamTutarTb.Size = new Size(256, 27);
            ToplamTutarTb.TabIndex = 10;
            // 
            // TaksitRB
            // 
            TaksitRB.AutoSize = true;
            TaksitRB.Location = new Point(159, 322);
            TaksitRB.Name = "TaksitRB";
            TaksitRB.Size = new Size(104, 24);
            TaksitRB.TabIndex = 2;
            TaksitRB.Text = "Taksitli öde";
            TaksitRB.UseVisualStyleBackColor = true;
            TaksitRB.CheckedChanged += TaksitRB_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 248);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 9;
            label7.Text = "Toplam Tutar";
            // 
            // PesinRB
            // 
            PesinRB.AutoSize = true;
            PesinRB.Checked = true;
            PesinRB.Location = new Point(20, 322);
            PesinRB.Name = "PesinRB";
            PesinRB.Size = new Size(95, 24);
            PesinRB.TabIndex = 1;
            PesinRB.TabStop = true;
            PesinRB.Text = "Peşin Öde";
            PesinRB.UseVisualStyleBackColor = true;
            // 
            // AdetTb
            // 
            AdetTb.Enabled = false;
            AdetTb.Location = new Point(6, 198);
            AdetTb.Name = "AdetTb";
            AdetTb.Size = new Size(196, 27);
            AdetTb.TabIndex = 8;
            AdetTb.Text = "1";
            AdetTb.TextChanged += AdetTb_TextChanged;
            // 
            // taksitTutari
            // 
            taksitTutari.FormattingEnabled = true;
            taksitTutari.Items.AddRange(new object[] { "3", "6", "9", "12" });
            taksitTutari.Location = new Point(159, 353);
            taksitTutari.Name = "taksitTutari";
            taksitTutari.Size = new Size(104, 28);
            taksitTutari.TabIndex = 0;
            taksitTutari.Visible = false;
            taksitTutari.SelectedIndexChanged += taksitTutari_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 175);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 7;
            label8.Text = "Adet";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MusteriAdiTb);
            groupBox2.Controls.Add(MSoyadTb);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(MAdiTb);
            groupBox2.Controls.Add(MNoTb);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dataGridViewMusteri);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(917, 373);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // MusteriAdiTb
            // 
            MusteriAdiTb.Location = new Point(655, 145);
            MusteriAdiTb.Name = "MusteriAdiTb";
            MusteriAdiTb.Size = new Size(256, 27);
            MusteriAdiTb.TabIndex = 7;
            // 
            // MSoyadTb
            // 
            MSoyadTb.Location = new Point(655, 218);
            MSoyadTb.Name = "MSoyadTb";
            MSoyadTb.Size = new Size(256, 27);
            MSoyadTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 195);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 5;
            label4.Text = "Müşteri Soyadı";
            // 
            // MAdiTb
            // 
            MAdiTb.Location = new Point(655, 23);
            MAdiTb.Name = "MAdiTb";
            MAdiTb.PlaceholderText = "İsim yazarak arama yapabilirsiniz";
            MAdiTb.Size = new Size(256, 27);
            MAdiTb.TabIndex = 2;
            MAdiTb.TextChanged += textBox1_TextChanged;
            // 
            // MNoTb
            // 
            MNoTb.Location = new Point(655, 83);
            MNoTb.Name = "MNoTb";
            MNoTb.Size = new Size(256, 27);
            MNoTb.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(655, 122);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 3;
            label5.Text = "Müşteri Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(655, 59);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 1;
            label6.Text = "Müşteri No";
            // 
            // dataGridViewMusteri
            // 
            dataGridViewMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMusteri.Dock = DockStyle.Left;
            dataGridViewMusteri.Location = new Point(3, 23);
            dataGridViewMusteri.Name = "dataGridViewMusteri";
            dataGridViewMusteri.RowHeadersWidth = 51;
            dataGridViewMusteri.RowTemplate.Height = 29;
            dataGridViewMusteri.Size = new Size(646, 347);
            dataGridViewMusteri.TabIndex = 0;
            dataGridViewMusteri.CellClick += dataGridViewMusteri_CellClick;
            // 
            // SatisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 782);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SatisForm";
            Text = "SatisForm";
            Load += SatisForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrun).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMusteri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox UBNoTb;
        private Label label1;
        private DataGridView dataGridViewUrun;
        private GroupBox groupBox3;
        private TextBox USatisTb;
        private Label label3;
        private TextBox UStokTb;
        private Label label2;
        private TextBox ToplamTutarTb;
        private RadioButton TaksitRB;
        private Label label7;
        private RadioButton PesinRB;
        private TextBox AdetTb;
        private ComboBox taksitTutari;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox MSoyadTb;
        private Label label4;
        private TextBox MNoTb;
        private Label label5;
        private TextBox MAdiTb;
        private Label label6;
        private DataGridView dataGridViewMusteri;
        private Button button1;
        private Label label9;
        private TextBox MusteriAdiTb;
        private Button button3;
        private Button button2;
    }
}