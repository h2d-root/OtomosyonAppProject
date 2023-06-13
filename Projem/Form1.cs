using Microsoft.Extensions.DependencyInjection;
using Projem;
using Projem.Models;

namespace FormApp_Core
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }
        private void YeniKayitBTN_Click(object sender, EventArgs e)
        {
            ClearGB();
        }
        public void Yenile()
        {
            using (OtomasyonContext context = new OtomasyonContext())
            {
                MusterilerDGV.DataSource = context.Musteriler.ToList();
            }
        }
        public void ClearGB()
        {
            MusteriNoTB.Clear();
            MusteriAdiTB.Clear();
            MusteriSoyadiTB.Clear();
            MusteriAdresiRTB.Clear();
            MusteriEpostaTb.Clear();
            MusteriTelefonNoTb.Clear();
        }
        private void MusterilerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriNoTB.Text = MusterilerDGV.CurrentRow.Cells[0].Value.ToString();
            MusteriAdiTB.Text = MusterilerDGV.CurrentRow.Cells[1].Value.ToString();
            MusteriSoyadiTB.Text = MusterilerDGV.CurrentRow.Cells[2].Value.ToString();
            MusteriTelefonNoTb.Text = MusterilerDGV.CurrentRow.Cells[3].Value.ToString();
            MusteriEpostaTb.Text = MusterilerDGV.CurrentRow.Cells[5].Value.ToString();
            MusteriAdresiRTB.Text = MusterilerDGV.CurrentRow.Cells[4].Value.ToString();
        }

        public Musteri EsitleTers(Musteri musteri)
        {
            MusteriNoTB.Text = musteri.Id.ToString();
            MusteriAdiTB.Text = musteri.Ad;
            MusteriSoyadiTB.Text = musteri.Soyad;
            MusteriAdresiRTB.Text = musteri.Adres;
            MusteriEpostaTb.Text = musteri.Eposta;
            MusteriTelefonNoTb.Text = musteri.Telefon;
            return musteri;
        }
        public Musteri Esitle()
        {
            Musteri musteri = new Musteri()
            {
                Ad = MusteriAdiTB.Text,
                Soyad = MusteriSoyadiTB.Text,
                Eposta = MusteriEpostaTb.Text,
                Telefon = MusteriTelefonNoTb.Text,
                Adres = MusteriAdresiRTB.Text
            };
            return musteri;
        }
        private void KaydetBTN_Click(object sender, EventArgs e)
        {
            using (OtomasyonContext context = new OtomasyonContext())
            {
                context.Musteriler.Add(Esitle());
            }
        }

        private void DegistirBTN_Click(object sender, EventArgs e)
        {
            Musteri musteri = Esitle();
            musteri.Id = Convert.ToInt32(MusterilerDGV.CurrentRow.Cells[0].Value);
            var result = _musteriManager.Update(musteri);
            if (result)
            {
                MessageBox.Show("müşteri bilgileri güncellenmiştir.");
                Yenile();
            }
            else
            {
                MessageBox.Show("müşteri bilgileri güncellenemedi!");
            }
        }

        private void SilBTN_Click(object sender, EventArgs e)
        {
            Musteri musteri = Esitle();
            musteri.Id = Convert.ToInt32(MusterilerDGV.CurrentRow.Cells[0].Value);
            var result = _musteriManager.Delete(musteri);
            if (result)
            {
                MessageBox.Show("müşteri bilgileri silindi");
                Yenile();
            }
            else
            {
                MessageBox.Show("müşteri bilgileri silinilemedi!");
            }
        }


        private void GirisSayfasiBTN_Click(object sender, EventArgs e)
        {
            var girisForm = Program.ServiceProvider.GetRequiredService<GirisForm>();
            girisForm.Show();
            this.Hide();
        }

        private void IlkKayitBTN_Click(object sender, EventArgs e)
        {
            var result = _musteriManager.GetFirstData();
            EsitleTers(result);
        }

        private void SonKayitBTN_Click(object sender, EventArgs e)
        {
            var result = _musteriManager.GetLastData();
            EsitleTers(result);
        }

        private void geriBTN_Click(object sender, EventArgs e)
        {
            Musteri musteri;
            int mevcutId = AppInfo.MusterilerList.FindIndex(x => x.Id == Convert.ToInt32(MusteriNoTB.Text));
            int geriId = mevcutId - 1;
            if (mevcutId > 0)
            {
                musteri = AppInfo.MusterilerList[geriId];
                EsitleTers(musteri);
            }
            else
            {
                var result = _musteriManager.GetFirstData();
                EsitleTers(result);
            }

        }

        private void IleriBTN_Click(object sender, EventArgs e)
        {
            Musteri musteri;
            int mevcutId = AppInfo.MusterilerList.FindIndex(x => x.Id == Convert.ToInt32(MusteriNoTB.Text));
            int ileriId = mevcutId + 1;
            if (ileriId < AppInfo.MusterilerList.Count)
            {
                musteri = AppInfo.MusterilerList[ileriId];
                EsitleTers(musteri);
            }
            else
            {
                var result = _musteriManager.GetLastData();
                EsitleTers(result);
            }



        }
    }
}