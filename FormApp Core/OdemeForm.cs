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
    }
}
