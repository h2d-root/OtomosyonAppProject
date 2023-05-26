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
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }
        public void YenileMusteri(List<Musteri> musteri)
        {
            dataGridViewMusteri.DataSource = musteri;
        }
        public void YenileTaksit(List<Taksit> taksit)
        {
            dataGridViewTaksit.DataSource = taksit;
        }
        private void dataGridViewMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MNoTb.Text = dataGridViewMusteri.CurrentRow.Cells[0].Value.ToString();
            MusteriAdiTb.Text = dataGridViewMusteri.CurrentRow.Cells[1].Value.ToString();
            MSoyadTb.Text = dataGridViewMusteri.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridViewTaksit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TNoTb.Text = dataGridViewTaksit.CurrentRow.Cells[0].Value.ToString();
            TTutarTb.Text = dataGridViewTaksit.CurrentRow.Cells[4].Value.ToString();
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            YenileMusteri(MusteriDal.GetAll());
            YenileTaksit(SatisTaksitOdemeDal.GetAllTaksit());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (SatisTaksitOdemeDal.AddOdeme(new Odeme()
            {
                TaksitId = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[0].Value),
                MusteriId = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[2].Value),
                OdemeTarihi = DateTime.Now.ToShortDateString(),
                OdemeTutarı = Convert.ToDecimal(dataGridViewTaksit.CurrentRow.Cells[4].Value),
            }))
            {
                Taksit taksit = new Taksit()
                {
                    Id = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[0].Value),
                    SatisId = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[1].Value),
                    MusteriId = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[2].Value),
                    VadeSayisi = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[3].Value) - 1,
                    TaksitTutari = Convert.ToInt32(dataGridViewTaksit.CurrentRow.Cells[4].Value),
                };
                SatisTaksitOdemeDal.UpdateTaksit(taksit);
                MessageBox.Show("Ödeme işlemi başarılı olmuştır");
                YenileTaksit(SatisTaksitOdemeDal.GetAllTaksit());
                MNoTb.Text = "1";
                MusteriAdiTb.Clear();
                MSoyadTb.Clear();
                TTutarTb.Clear();
                TNoTb.Clear();
            }
        }

        private void MAdiTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MNoTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YenileTaksit(SatisTaksitOdemeDal.GetMusteriTaksit(Convert.ToInt32(MNoTb.Text)));

            }
            catch (FormatException)
            {
                MessageBox.Show("Müşteri Numarası sadece sayı olabilir");
                MNoTb.Text = "0";
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
