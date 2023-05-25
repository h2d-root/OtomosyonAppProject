using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_Core
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void MusteriFormBTN_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void UrunFormBTN_Click(object sender, EventArgs e)
        {
            UrunIslemForm urunIslemForm = new UrunIslemForm();
            urunIslemForm.Show();
            this.Hide();
        }
    }
}
