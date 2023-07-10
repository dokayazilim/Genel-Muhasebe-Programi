using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void Form38_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdigerhesaplarDataSet3.kiralistesi' table. You can move, or remove it, as needed.
            this.kiralistesiTableAdapter.Fill(this.mhsbdigerhesaplarDataSet3.kiralistesi);

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adisoyadi.Clear();
            tckimlik.Clear();
            meslegi.Clear();
            evet.Checked = false;
            hayir.Checked = false;
            tumu.Checked = false;
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adisoyadi.Clear();
            tckimlik.Clear();
            meslegi.Clear();
            evet.Checked = false;
            hayir.Checked = false;
            tumu.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kira listesi bulunamadı.","Kira Listesi");
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kira listesi bulunamadı.", "Kira Listesi");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
