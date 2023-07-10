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
    public partial class Form17 : Form
    {
        public Form17()
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

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet3.kapanisfisiolustur' table. You can move, or remove it, as needed.
            this.kapanisfisiolusturTableAdapter.Fill(this.mhsbortakDataSet3.kapanisfisiolustur);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaplanacak fiş kaydı bulunamadı.","Kapanış Fişi Oluştur");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kapanış fişi oluşturamazsınız.","Kapanış Fişi Oluştur");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form92 a = new Form92();
            a.Show();
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaplanacak fiş kaydı bulunamadı.", "Kapanış Fişi Oluştur");
        }

        private void fişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kapanış fişi oluşturamazsınız.", "Kapanış Fişi Oluştur");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
