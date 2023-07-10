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
    public partial class Form43 : Form
    {
        public Form43()
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
            ozelfisdahilet.Checked = false;
            ozelfisdahiletme.Checked = false;
            oncekidonemgoster.Checked = false;
            oncekidonemgosterme.Checked = false;
            bakiyesizhesapgoster.Checked = false;
            bakiyesizhesapgosterme.Checked = false;
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ozelfisdahilet.Checked = false;
            ozelfisdahiletme.Checked = false;
            oncekidonemgoster.Checked = false;
            oncekidonemgosterme.Checked = false;
            bakiyesizhesapgoster.Checked = false;
            bakiyesizhesapgosterme.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form43_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet15.ayrintiligelirtablosu' table. You can move, or remove it, as needed.
            this.ayrintiligelirtablosuTableAdapter.Fill(this.mhsbortakDataSet15.ayrintiligelirtablosu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rapor kaydedilemedi.", "Ayrıntılı Gelir Tablosu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla tabloya aktarıldı.", "Ayrıntılı Gelir Tablosu");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla tabloya aktarıldı.", "Ayrıntılı Gelir Tablosu");
        }

        private void raporuKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rapor kaydedilemedi.", "Ayrıntılı Gelir Tablosu");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
