namespace FormApp_Core
{
    partial class OdemeForm
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
            groupBox2 = new GroupBox();
            MusteriAdiTb = new TextBox();
            MSoyadTb = new TextBox();
            label4 = new Label();
            MNoTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridViewMusteri = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            TTutarTb = new TextBox();
            label2 = new Label();
            TNoTb = new TextBox();
            label1 = new Label();
            dataGridViewTaksit = new DataGridView();
            GirisSayfasiBTN = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMusteri).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaksit).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GirisSayfasiBTN);
            groupBox2.Controls.Add(MusteriAdiTb);
            groupBox2.Controls.Add(MSoyadTb);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(MNoTb);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dataGridViewMusteri);
            groupBox2.Location = new Point(12, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1185, 395);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // MusteriAdiTb
            // 
            MusteriAdiTb.Location = new Point(786, 177);
            MusteriAdiTb.Name = "MusteriAdiTb";
            MusteriAdiTb.Size = new Size(256, 27);
            MusteriAdiTb.TabIndex = 7;
            // 
            // MSoyadTb
            // 
            MSoyadTb.Location = new Point(786, 250);
            MSoyadTb.Name = "MSoyadTb";
            MSoyadTb.Size = new Size(256, 27);
            MSoyadTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(786, 227);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 5;
            label4.Text = "Müşteri Soyadı";
            // 
            // MNoTb
            // 
            MNoTb.Location = new Point(786, 115);
            MNoTb.Name = "MNoTb";
            MNoTb.PlaceholderText = "Müşteri No Girerek Arama Yapınız";
            MNoTb.Size = new Size(256, 27);
            MNoTb.TabIndex = 4;
            MNoTb.TextChanged += MNoTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(786, 154);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 3;
            label5.Text = "Müşteri Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(786, 91);
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
            dataGridViewMusteri.Size = new Size(646, 369);
            dataGridViewMusteri.TabIndex = 0;
            dataGridViewMusteri.CellClick += dataGridViewMusteri_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TTutarTb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TNoTb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridViewTaksit);
            groupBox1.Location = new Point(12, 392);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1191, 378);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Taksit Bilgileri";
            // 
            // button1
            // 
            button1.Location = new Point(816, 270);
            button1.Name = "button1";
            button1.Size = new Size(196, 46);
            button1.TabIndex = 12;
            button1.Text = "ödemeyi tamamla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TTutarTb
            // 
            TTutarTb.Enabled = false;
            TTutarTb.Location = new Point(786, 192);
            TTutarTb.Name = "TTutarTb";
            TTutarTb.Size = new Size(256, 27);
            TTutarTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(786, 169);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Taksit Tutarı";
            // 
            // TNoTb
            // 
            TNoTb.Enabled = false;
            TNoTb.Location = new Point(786, 115);
            TNoTb.Name = "TNoTb";
            TNoTb.Size = new Size(256, 27);
            TNoTb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(786, 92);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Taksit No";
            // 
            // dataGridViewTaksit
            // 
            dataGridViewTaksit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaksit.Dock = DockStyle.Left;
            dataGridViewTaksit.Location = new Point(3, 23);
            dataGridViewTaksit.Name = "dataGridViewTaksit";
            dataGridViewTaksit.RowHeadersWidth = 51;
            dataGridViewTaksit.RowTemplate.Height = 29;
            dataGridViewTaksit.Size = new Size(646, 352);
            dataGridViewTaksit.TabIndex = 0;
            dataGridViewTaksit.CellClick += dataGridViewTaksit_CellClick;
            // 
            // GirisSayfasiBTN
            // 
            GirisSayfasiBTN.Location = new Point(1014, 10);
            GirisSayfasiBTN.Name = "GirisSayfasiBTN";
            GirisSayfasiBTN.Size = new Size(165, 29);
            GirisSayfasiBTN.TabIndex = 17;
            GirisSayfasiBTN.Text = "Giriş Ekranına dön";
            GirisSayfasiBTN.UseVisualStyleBackColor = true;
            GirisSayfasiBTN.Click += GirisSayfasiBTN_Click;
            // 
            // OdemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 782);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OdemeForm";
            Text = "OdemeForm";
            Load += OdemeForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMusteri).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaksit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox MusteriAdiTb;
        private TextBox MSoyadTb;
        private Label label4;
        private TextBox MNoTb;
        private Label label5;
        private Label label6;
        private DataGridView dataGridViewMusteri;
        private GroupBox groupBox1;
        private TextBox TNoTb;
        private Label label1;
        private DataGridView dataGridViewTaksit;
        private TextBox TTutarTb;
        private Label label2;
        private Button button1;
        private Button GirisSayfasiBTN;
    }
}