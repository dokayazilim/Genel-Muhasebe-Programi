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
    public partial class Form47 : Form
    {
        public Form47()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kapartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vergidairesi.Clear();
            donemtipi.SelectedIndex = -1;
            vergikimlikno.Clear();
            soyadi.Clear();
            adi.Clear();
            ticaretsicilno.Clear();
            email.Clear();
            telalankodu.Clear();
            telnumara.Clear();
            beyannamedebeyanyok.Checked = false;
            // 2. bölüm
            formbstoplam.Clear();
            formbsdigermal.Clear();
            formbsgeneltoplam.Clear();
            formbsbudonem.Clear();
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vergidairesi.Clear();
            donemtipi.SelectedIndex = -1;
            vergikimlikno.Clear();
            soyadi.Clear();
            adi.Clear();
            ticaretsicilno.Clear();
            email.Clear();
            telalankodu.Clear();
            telnumara.Clear();
            beyannamedebeyanyok.Checked = false;
            // 2. bölüm
            formbstoplam.Clear();
            formbsdigermal.Clear();
            formbsgeneltoplam.Clear();
            formbsbudonem.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void excelEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form47_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet34.formbsbilancoesasinagoredeftertutanmukellefler' table. You can move, or remove it, as needed.
            this.formbsbilancoesasinagoredeftertutanmukelleflerTableAdapter.Fill(this.mhsbdataDataSet34.formbsbilancoesasinagoredeftertutanmukellefler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet24.formbs' table. You can move, or remove it, as needed.
            this.formbsTableAdapter.Fill(this.mhsbdataDataSet24.formbs);

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");

        }

        private void xMLEOlarakKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde beyanname kaydı yapılamaz veya gönderilemez.", "Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form82 a = new Form82();
            a.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde beyanname kaydı yapılamaz veya gönderilemez.", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
