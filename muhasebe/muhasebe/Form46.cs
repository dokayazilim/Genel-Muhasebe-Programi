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
    public partial class Form46 : Form
    {
        public Form46()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

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
            formbatoplam.Clear();
            formbadigertoplam.Clear();
            formbageneltoplam.Clear();
            formbudonemeait.Clear();
            
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
            formbatoplam.Clear();
            formbadigertoplam.Clear();
            formbageneltoplam.Clear();
            formbudonemeait.Clear();
        }

        private void kapartToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form46_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet33.formbabilancoesasinagoredeftertutanmukellefler' table. You can move, or remove it, as needed.
            this.formbabilancoesasinagoredeftertutanmukelleflerTableAdapter.Fill(this.mhsbdataDataSet33.formbabilancoesasinagoredeftertutanmukellefler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet23.formba' table. You can move, or remove it, as needed.
            this.formbaTableAdapter.Fill(this.mhsbdataDataSet23.formba);

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
            Form81 a = new Form81();
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
