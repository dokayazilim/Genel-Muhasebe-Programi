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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dahilet.Checked = false;
            dahiletme.Checked = false;
            goster.Checked = false;
            gosterme.Checked = false;
            bakiyegoster.Checked = false;
            bakiyegosterme.Checked = false;
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dahilet.Checked = false;
            dahiletme.Checked = false;
            goster.Checked = false;
            gosterme.Checked = false;
            bakiyegoster.Checked = false;
            bakiyegosterme.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet6.ayrintilibilanco' table. You can move, or remove it, as needed.
            this.ayrintilibilancoTableAdapter.Fill(this.mhsbortakDataSet6.ayrintilibilanco);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaplanacak bilanço bulunamadı.", "Ayrıntılı Bilanço");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaplanacak bilanço bulunamadı.", "Ayrıntılı Bilanço");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
