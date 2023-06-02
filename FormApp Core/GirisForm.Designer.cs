namespace FormApp_Core
{
    partial class GirisForm
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
            MusteriFormBTN = new Button();
            UrunFormBTN = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // MusteriFormBTN
            // 
            MusteriFormBTN.Location = new Point(215, 82);
            MusteriFormBTN.Margin = new Padding(3, 2, 3, 2);
            MusteriFormBTN.Name = "MusteriFormBTN";
            MusteriFormBTN.Size = new Size(256, 34);
            MusteriFormBTN.TabIndex = 0;
            MusteriFormBTN.Text = "Müşteri İşlemleri";
            MusteriFormBTN.UseVisualStyleBackColor = true;
            MusteriFormBTN.Click += MusteriFormBTN_Click;
            // 
            // UrunFormBTN
            // 
            UrunFormBTN.Location = new Point(215, 121);
            UrunFormBTN.Margin = new Padding(3, 2, 3, 2);
            UrunFormBTN.Name = "UrunFormBTN";
            UrunFormBTN.Size = new Size(256, 34);
            UrunFormBTN.TabIndex = 0;
            UrunFormBTN.Text = "Ürün İşlemleri";
            UrunFormBTN.UseVisualStyleBackColor = true;
            UrunFormBTN.Click += UrunFormBTN_Click;
            // 
            // button3
            // 
            button3.Location = new Point(215, 159);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(256, 34);
            button3.TabIndex = 0;
            button3.Text = "Satış İşlemleri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(215, 197);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(256, 34);
            button4.TabIndex = 0;
            button4.Text = "Ödeme İşlemleri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(UrunFormBTN);
            Controls.Add(MusteriFormBTN);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GirisForm";
            Text = "GirisForm";
            Load += GirisForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MusteriFormBTN;
        private Button UrunFormBTN;
        private Button button3;
        private Button button4;
    }
}