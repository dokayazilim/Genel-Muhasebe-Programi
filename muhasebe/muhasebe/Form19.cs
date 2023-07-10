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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fisno.Clear();
            evrakno.Clear();
            fistipi.SelectedIndex = -1;
            tumdetay.Checked = false;
            gosterme.Checked = false;

        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fisno.Clear();
            evrakno.Clear();
            fistipi.SelectedIndex = -1;
            tumdetay.Checked = false;
            gosterme.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet38.yevmiyedefteri' table. You can move, or remove it, as needed.
            this.yevmiyedefteriTableAdapter.Fill(this.mhsbdataDataSet38.yevmiyedefteri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt bulunamadı.","Yevmiye Defteri");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt bulunamadı.", "Yevmiye Defteri");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
