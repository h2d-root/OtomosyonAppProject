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
            MusteriFormBTN.Location = new Point(246, 110);
            MusteriFormBTN.Name = "MusteriFormBTN";
            MusteriFormBTN.Size = new Size(293, 45);
            MusteriFormBTN.TabIndex = 0;
            MusteriFormBTN.Text = "button1";
            MusteriFormBTN.UseVisualStyleBackColor = true;
            MusteriFormBTN.Click += MusteriFormBTN_Click;
            // 
            // UrunFormBTN
            // 
            UrunFormBTN.Location = new Point(246, 161);
            UrunFormBTN.Name = "UrunFormBTN";
            UrunFormBTN.Size = new Size(293, 45);
            UrunFormBTN.TabIndex = 0;
            UrunFormBTN.Text = "button1";
            UrunFormBTN.UseVisualStyleBackColor = true;
            UrunFormBTN.Click += UrunFormBTN_Click;
            // 
            // button3
            // 
            button3.Location = new Point(246, 212);
            button3.Name = "button3";
            button3.Size = new Size(293, 45);
            button3.TabIndex = 0;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(246, 263);
            button4.Name = "button4";
            button4.Size = new Size(293, 45);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(UrunFormBTN);
            Controls.Add(MusteriFormBTN);
            Name = "GirisForm";
            Text = "GirisForm";
            ResumeLayout(false);
        }

        #endregion

        private Button MusteriFormBTN;
        private Button UrunFormBTN;
        private Button button3;
        private Button button4;
    }
}