using Business.Abstract;
using Business.Service;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace FormApp_Core
{
    public partial class UrunIslemForm : Form
    {
        IUrunService _urunManager;


        public UrunIslemForm(IUrunService urunManager)
        {
            InitializeComponent();
            _urunManager = urunManager;
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
            UrunlerDGV.DataSource = _urunManager.GetAll();
            
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
            var result = _urunManager.Add(Esitle());
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
            Urun urun = Esitle();
            urun.Id = Guid.Parse(UrunlerDGV.CurrentRow.Cells[0].Value.ToString());
            var result = _urunManager.Update(urun);
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
            Urun urun = Esitle();
            urun.Id = Guid.Parse(UrunlerDGV.CurrentRow.Cells[0].Value.ToString());
            var result = _urunManager.Delete(urun);
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
        public Urun EsitleTers(Urun urun)
        {

            BarkodNoTB.Text = urun.Id.ToString();
            UrunAdiTB.Text = urun.Isim;
            UrunMarkaTB.Text = urun.Marka;
            UrunModelTB.Text = urun.Model;
            UrunRenkTB.Text = urun.Renk;
            UrunStokTB.Text = urun.Stok.ToString();
            AlisFiyatiTb.Text = urun.AlisTutar.ToString();
            SatisFiyatTB.Text = urun.SatisTutar.ToString();
            ToplamSatilanTB.Text = urun.Satilan.ToString();
            return urun;
        }

        private void GirisSayfasiBTN_Click(object sender, EventArgs e)
        {
            var girisForm = Program.ServiceProvider.GetRequiredService<GirisForm>();
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

        private void IlkKayitBTN_Click(object sender, EventArgs e)
        {
            Urun urun = _urunManager.GetFirstData();
            EsitleTers(urun);
        }

        private void SonKayitBTN_Click(object sender, EventArgs e)
        {
            Urun urun = _urunManager.GetLastData();
            EsitleTers(urun);
        }

        private void geriBTN_Click(object sender, EventArgs e)
        {
            Urun urun;
            int mevcutId = AppInfo.UrunlerList.FindIndex(x => x.Id == Guid.Parse(BarkodNoTB.Text));
            int geriId = mevcutId - 1;
            if (geriId > AppInfo.UrunlerList.Count)
            {
                urun = AppInfo.UrunlerList[geriId];
                EsitleTers(urun);

            }
            else
            {
                urun = _urunManager.GetFirstData();
                EsitleTers(urun);
            }
        }

        private void IleriBTN_Click(object sender, EventArgs e)
        {

            Urun urun;
            int mevcutId = AppInfo.UrunlerList.FindIndex(x => x.Id == Guid.Parse(BarkodNoTB.Text));
            int ileriId = mevcutId + 1;
            if (ileriId < AppInfo.UrunlerList.Count)
            {
                urun = AppInfo.UrunlerList[ileriId];
                EsitleTers(urun);

            }
            else
            {
                urun = _urunManager.GetLastData();
                EsitleTers(urun);
            }
        }
    }
}
