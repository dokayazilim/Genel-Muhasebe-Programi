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
    public partial class Form33 : Form
    {
        public Form33()
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

        private void button4_Click(object sender, EventArgs e)
        {
            hesapkodu.Clear();
            hesapkodu2.Clear();
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapkodu.Clear();
            hesapkodu2.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form33_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet8.virmanhesabinaaktarim' table. You can move, or remove it, as needed.
            this.virmanhesabinaaktarimTableAdapter.Fill(this.mhsbortakDataSet8.virmanhesabinaaktarim);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen öncelikle kayıt yapınız!","Virman Hesabına Aktarım");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Virman hesabı oluşturulamadı!","Virman Hesabına Aktarım");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form90 a = new Form90();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form91 a = new Form91();
            a.Show();
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen öncelikle kayıt yapınız!", "Virman Hesabına Aktarım");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
