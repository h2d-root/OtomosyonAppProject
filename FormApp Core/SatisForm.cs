using Business.Abstract;
using Entities.Concrete;

namespace FormApp_Core
{
    public partial class SatisForm : Form
    {
        IMusteriService _musteriManager;
        ITaksitService _taksitManager;
        IUrunService _urunManager;
        IOdemeService _odemeManager;
        ISatisService _satisManager;
        public SatisForm()
        {
            InitializeComponent();
        }

        public SatisForm(IMusteriService musteriManager, ITaksitService taksitManager, IUrunService urunManager, IOdemeService odemeManager, ISatisService satisManager)
        {
            _musteriManager = musteriManager;
            _taksitManager = taksitManager;
            _urunManager = urunManager;
            _odemeManager = odemeManager;
            _satisManager = satisManager;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            YenileMusteri(_musteriManager.GetByString(MAdiTb.Text));
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            YenileMusteri(_musteriManager.GetAll());
            YenileUrun(_urunManager.GetAll());
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
                if (_satisManager.Add(satis))
                {
                    Urun urun = new Urun()
                    {
                        Id = Guid.Parse(dataGridViewUrun.CurrentRow.Cells[0].Value.ToString()),
                        Isim = dataGridViewUrun.CurrentRow.Cells[1].Value.ToString(),
                        Marka = dataGridViewUrun.CurrentRow.Cells[3].Value.ToString(),
                        Model = dataGridViewUrun.CurrentRow.Cells[4].Value.ToString(),
                        Renk = dataGridViewUrun.CurrentRow.Cells[2].Value.ToString(),
                        Stok = Convert.ToInt32(dataGridViewUrun.CurrentRow.Cells[5].Value.ToString()) - Convert.ToInt32(AdetTb.Text),
                        AlisTutar = Convert.ToDecimal(dataGridViewUrun.CurrentRow.Cells[7].Value.ToString()),
                        SatisTutar = Convert.ToDecimal(dataGridViewUrun.CurrentRow.Cells[8].Value.ToString()),
                        Satilan = Convert.ToInt32(dataGridViewUrun.CurrentRow.Cells[6].Value.ToString()) + Convert.ToInt32(AdetTb.Text)
                    };
                    _urunManager.Update(urun);
                    MessageBox.Show("satış tamamlandı");
                    YenileUrun(_urunManager.GetAll());
                    if (TaksitRB.Checked)
                    {
                        Taksit taksit = new Taksit()
                        {
                            MusteriId = Convert.ToInt32(MNoTb.Text),
                            VadeSayisi = Convert.ToInt32(taksitTutari.Text),
                            SatisId = _satisManager.LastData().Id,
                            TaksitTutari = Convert.ToDecimal(label9.Text),
                        };
                        _taksitManager.Add(taksit);
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

        private void GirisSayfasiBTN_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }
    }
}
