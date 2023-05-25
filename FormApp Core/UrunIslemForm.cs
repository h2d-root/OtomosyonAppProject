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
            UrunDal.StartData();
            Yenile();
        }

        public void Yenile()
        {
            UrunlerDGV.DataSource = UrunDal.GetAll();
        }
        public Urun Esitle()
        {
            Urun urun = new Urun()
            {
                Isim = UrunAdiTB.Text,
                Marka = UrunMarkaTB.Text,
                Model = UrunModelTB.Text,
                Renk = UrunRenkTB.Text,
                Stok = Convert.ToInt32(UrunStokTB.Text),
                AlisTutar = Convert.ToDecimal(AlisFiyatiTb.Text),
                SatisTutar = Convert.ToDecimal(SatisFiyatTB.Text),
                Satilan = Convert.ToInt32(ToplamSatilanTB.Text)
            };
            return urun;

        }

        private void YeniKayitBTN_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void KaydetBTN_Click(object sender, EventArgs e)
        {
            var result = UrunDal.Add(Esitle());
            if (result)
            {
                MessageBox.Show("Ürün bilgileri eklenmiştir.");
                Yenile();
            }
            else
            {
                MessageBox.Show("Ürün Eklenilemedi Tekrar deneyiniz!");
            }
        }

        private void DegistirBTN_Click(object sender, EventArgs e)
        {
            var result = UrunDal.Update(EsitleUpdateAndDelete());
            if (result)
            {
                MessageBox.Show("Ürün bilgileri güncellenmiştir.");
                Yenile();
            }
            else
            {
                MessageBox.Show("Ürün bilgileri güncellenemedi!");
            }
        }

        private void SilBTN_Click(object sender, EventArgs e)
        {
            var result = UrunDal.Delete(EsitleUpdateAndDelete());
            if (result)
            {
                MessageBox.Show("Ürün bilgileri silinmiştir.");
                Yenile();
            }
            else
            {
                MessageBox.Show("Ürün bilgileri silinilemedi!");
            }
        }

        public void Clear()
        {
            BarkodNoTB.Clear();
            UrunAdiTB.Clear();
            UrunRenkTB.Clear();
            UrunMarkaTB.Clear();
            UrunModelTB.Clear();
            UrunStokTB.Clear();
            AlisFiyatiTb.Clear();
            SatisFiyatTB.Clear();
            ToplamSatilanTB.Clear();
        }
        public Urun EsitleUpdateAndDelete()
        {
            Urun urun = new Urun()
            {
                Id = Guid.Parse(BarkodNoTB.Text),
                Isim = UrunAdiTB.Text,
                Marka = UrunMarkaTB.Text,
                Model = UrunModelTB.Text,
                Renk = UrunRenkTB.Text,
                Stok = Convert.ToInt32(UrunStokTB.Text),
                AlisTutar = Convert.ToDecimal(AlisFiyatiTb.Text),
                SatisTutar = Convert.ToDecimal(SatisFiyatTB.Text),
                Satilan = Convert.ToInt32(ToplamSatilanTB.Text)
            };
            return urun;
        }

        private void GirisSayfasiBTN_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }

        private void UrunlerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNoTB.Text = UrunlerDGV.CurrentRow.Cells[0].Value.ToString();
            UrunAdiTB.Text = UrunlerDGV.CurrentRow.Cells[1].Value.ToString();
            UrunRenkTB.Text = UrunlerDGV.CurrentRow.Cells[2].Value.ToString();
            UrunMarkaTB.Text = UrunlerDGV.CurrentRow.Cells[3].Value.ToString();
            UrunModelTB.Text = UrunlerDGV.CurrentRow.Cells[4].Value.ToString();
            UrunStokTB.Text = UrunlerDGV.CurrentRow.Cells[5].Value.ToString();
            ToplamSatilanTB.Text = UrunlerDGV.CurrentRow.Cells[6].Value.ToString();
            AlisFiyatiTb.Text = UrunlerDGV.CurrentRow.Cells[7].Value.ToString();
            SatisFiyatTB.Text = UrunlerDGV.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
