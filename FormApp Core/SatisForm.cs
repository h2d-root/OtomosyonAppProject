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
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            YenileMusteri(MusteriDal.GetByIsim(MAdiTb.Text));
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            YenileMusteri(MusteriDal.GetAll());
            YenileUrun(UrunDal.GetAll());
        }
        public void YenileMusteri(List<Musteri> musteri)
        {
            dataGridViewMusteri.DataSource = musteri;
        }
        public void YenileUrun(List<Urun> urun)
        {
            dataGridViewUrun.DataSource = urun;
        }

        private void dataGridViewMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MNoTb.Text = dataGridViewMusteri.CurrentRow.Cells[0].Value.ToString();
            MusteriAdiTb.Text = dataGridViewMusteri.CurrentRow.Cells[1].Value.ToString();
            MSoyadTb.Text = dataGridViewMusteri.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridViewUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UBNoTb.Text = dataGridViewUrun.CurrentRow.Cells[0].Value.ToString();
            UStokTb.Text = dataGridViewUrun.CurrentRow.Cells[5].Value.ToString();
            USatisTb.Text = dataGridViewUrun.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AdetTb.Text) <= Convert.ToInt32(UStokTb.Text))
            {
                Satis satis = new Satis()
                {
                    BarkodId = Guid.Parse(UBNoTb.Text),
                    MusteriId = Convert.ToInt32(MNoTb.Text),
                    Adet = Convert.ToInt32(AdetTb.Text),
                    Tutar = Convert.ToDecimal(ToplamTutarTb.Text),
                    SatisTarihi = DateTime.Now.ToShortDateString(),
                };
                if (SatisTaksitOdemeDal.AddSatis(satis))
                {
                    UrunDal.Updateid(Guid.Parse(UBNoTb.Text), Convert.ToInt32(AdetTb.Text));
                    MessageBox.Show("satış tamamlandı");
                    YenileUrun(UrunDal.GetAll());
                    if (TaksitRB.Checked)
                    {
                        Taksit taksit = new Taksit()
                        {
                            MusteriId = Convert.ToInt32(MNoTb.Text),
                            VadeSayisi = Convert.ToInt32(taksitTutari.Text),
                            SatisId = 0,
                            TaksitTutari = Convert.ToDecimal(label9.Text),
                        };
                        SatisTaksitOdemeDal.AddTaksit(taksit, DateTime.Now.ToShortDateString(), Guid.Parse(UBNoTb.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Satış yapılamadı");
                }
            }
            else
            {
                AdetTb.Text = "1";
                MessageBox.Show("Stok yeterli değil");
            }

        }

        private void AdetTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ToplamTutarTb.Text = (Convert.ToInt32(AdetTb.Text) * Convert.ToDecimal(USatisTb.Text)).ToString();
            }
            catch (FormatException)
            {
                AdetTb.Text = "1";
                MessageBox.Show("lütfen adet kısmına sadece sayı giriniz!");
            }
        }

        private void TaksitRB_CheckedChanged(object sender, EventArgs e)
        {
            if (TaksitRB.Checked)
            {
                taksitTutari.Visible = true;
                label9.Visible = true;

            }
            else
            {
                taksitTutari.Visible = false;
                label9.Visible = false;
                label9.Text = "";
            }
        }

        private void taksitTutari_SelectedIndexChanged(object sender, EventArgs e)
        {
            double one = Convert.ToDouble(taksitTutari.Text);
            double two = Convert.ToDouble(ToplamTutarTb.Text);
            double three = two / one;
            label9.Text = three.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(AdetTb.Text) + 1;
            if (adet <= Convert.ToInt32(UStokTb.Text))
            {
                AdetTb.Text = adet.ToString();
            }
            else
            {
                MessageBox.Show("satış yapılan ürün adeti stok sayısını geçemez");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(AdetTb.Text) - 1;
            if (adet > 0)
            {
                AdetTb.Text = adet.ToString();
            }
        }
    }
}
