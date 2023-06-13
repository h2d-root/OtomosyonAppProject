using Business.Abstract;
using Microsoft.Extensions.DependencyInjection;
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
            Form1 form1 = Program.ServiceProvider.GetRequiredService<Form1>();
            form1.Show();
            this.Hide();
        }

        private void UrunFormBTN_Click(object sender, EventArgs e)
        {
            UrunIslemForm urunIslemForm = Program.ServiceProvider.GetRequiredService<UrunIslemForm>();
            urunIslemForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisForm satisForm = Program.ServiceProvider.GetRequiredService<SatisForm>();
            satisForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdemeForm odemeForm = Program.ServiceProvider.GetRequiredService<OdemeForm>();
            odemeForm.Show();
            this.Hide();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
