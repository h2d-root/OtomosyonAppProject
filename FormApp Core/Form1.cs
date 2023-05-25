using FormApp_Core.DataAccess;
using FormApp_Core.Entities;

namespace FormApp_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriDal.StartData();
            Yenile();
        }
        private void YeniKayitBTN_Click(object sender, EventArgs e)
        {
            ClearGB();
        }
        public void Yenile()
        {
            MusterilerDGV.DataSource = MusteriDal.GetAll();
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

        public Musteri EsitleUpdateAndDelete()
        {
            Musteri musteri = new Musteri()
            {
                Id = Convert.ToInt32(MusteriNoTB.Text),
                Ad = MusteriAdiTB.Text,
                Soyad = MusteriSoyadiTB.Text,
                Eposta = MusteriEpostaTb.Text,
                Telefon = MusteriTelefonNoTb.Text,
                Adres = MusteriAdresiRTB.Text
            };
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
            var result = MusteriDal.Add(Esitle());
            if (result)
            {
                MessageBox.Show("Müþteri bilgileri eklenmiþtir.");
                Yenile();
            }
            else
            {
                MessageBox.Show("Müþteri Eklenilemedi Tekrar deneyiniz!");
            }
        }

        private void DegistirBTN_Click(object sender, EventArgs e)
        {
            var result = MusteriDal.Update(EsitleUpdateAndDelete());
            if (result)
            {
                MessageBox.Show("müþteri bilgileri güncellenmiþtir.");
                Yenile();
            }
            else
            {
                MessageBox.Show("müþteri bilgileri güncellenemedi!");
            }
        }

        private void SilBTN_Click(object sender, EventArgs e)
        {
            var result = MusteriDal.Delete(EsitleUpdateAndDelete());
            if (result)
            {
                MessageBox.Show("müþteri bilgileri silindi");
                Yenile();
            }
            else
            {
                MessageBox.Show("müþteri bilgileri silinilemedi!");
            }
        }


        private void GirisSayfasiBTN_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }
    }
}