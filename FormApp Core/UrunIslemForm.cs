using FormApp_Core.DataAccess;
using FormApp_Core.Entities;
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
    public partial class UrunIslemForm : Form
    {
        public UrunIslemForm()
        {
            InitializeComponent();
        }

        private void UrunAdiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunIslemForm_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        public void Yenile()
        {
            UrunlerDGV.DataSource = UrunDal.GetAll();
        }
        public void Esitle()
        {
            Urun urun = new Urun()
            {
                İsim = UrunAdiTB.Text,
                Marka = UrunMarkaTB.Text,
                Model = UrunModelTB.Text,
                Renk = UrunRenkTB.Text,
                Stok = Convert.ToInt32(UrunStokTB.Text),
                AlisTutar = Convert.ToDecimal(AlisFiyatiTb.Text),
                SatisTutar = Convert.ToInt32(SatisFiyatTB),
                Satilan = Convert.ToInt32(ToplamSatilanTB.Text)
            };

        }

        private void YeniKayitBTN_Click(object sender, EventArgs e)
        {

        }

        private void KaydetBTN_Click(object sender, EventArgs e)
        {

        }

        private void DegistirBTN_Click(object sender, EventArgs e)
        {

        }

        private void SilBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
