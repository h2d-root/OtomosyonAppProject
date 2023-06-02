using Business.Abstract;
using Business.AutoFac;
using Business.Concrete;
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
        IMusteriService musteriService;
        IUrunService urunService;
        IOdemeService odemeService;
        ITaksitService taksitService;
        ISatisService satisService;
        public GirisForm()
        {
            InitializeComponent();
        }

        public GirisForm(IMusteriService musteriService, IUrunService urunService, IOdemeService odemeService, ITaksitService taksitService, ISatisService satisService)
        {
            this.musteriService = musteriService;
            this.urunService = urunService;
            this.odemeService = odemeService;
            this.taksitService = taksitService;
            this.satisService = satisService;
        }

        private void MusteriFormBTN_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(musteriService);
            form1.Show();
            this.Hide();
        }

        private void UrunFormBTN_Click(object sender, EventArgs e)
        {
            UrunIslemForm urunIslemForm = new UrunIslemForm(urunService);
            urunIslemForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SatisForm satisForm = new SatisForm(musteriService,taksitService, urunService, satisService);
            satisForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdemeForm odemeForm = new OdemeForm(musteriService, taksitService, odemeService);
            odemeForm.Show();
            this.Hide();
        }
    }
}
