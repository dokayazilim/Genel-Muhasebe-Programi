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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            goster.Checked = false;
            gosterme.Checked = false;
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goster.Checked = false;
            gosterme.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet13.satislarinmaliyeti' table. You can move, or remove it, as needed.
            this.satislarinmaliyetiTableAdapter.Fill(this.mhsbortakDataSet13.satislarinmaliyeti);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydedilecek rapor bulunamadı!","Satışların Maliyeti");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raporlar başarıyla tabloya aktarıldı.", "Satışların Maliyeti");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void raporuKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydedilecek rapor bulunamadı!", "Satışların Maliyeti");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raporlar başarıyla tabloya aktarıldı.", "Satışların Maliyeti");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
