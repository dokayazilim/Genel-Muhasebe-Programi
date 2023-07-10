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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void kayıtlaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kaoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aysecimi.SelectedIndex = -1;
            hesapkodu.Clear();
            hesapkodu2.Clear();
            detaygoster.SelectedIndex = -1;
            dokumbicimi.SelectedIndex = -1;
            bakiyedurumu.SelectedIndex = -1;
            kapanis.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void excelEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

      
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet2.aylikmizan' table. You can move, or remove it, as needed.
            this.aylikmizanTableAdapter.Fill(this.mhsbortakDataSet2.aylikmizan);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir kayıt bulunamadı.","Aylık Mizan");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form102 a = new Form102();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form103 a = new Form103();
            a.Show();
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir kayıt bulunamadı.", "Aylık Mizan");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
