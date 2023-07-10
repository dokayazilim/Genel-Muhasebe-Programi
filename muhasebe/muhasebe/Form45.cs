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
    public partial class Form45 : Form
    {
        public Form45()
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            vergidairesi.Clear();
            vergikimlikno.Clear();
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
            yurtdisinayapilanodeme.Clear();
            serinoluodeme.Clear();
            geneltoplam.Clear();
            // 3.bölüm
            tamtevfikatvergitoplami.Clear();
            kismivergitoplami.Clear();
            kdvmatrah.Clear();
            tevkifedilenkdv.Clear();
            ilaveedilecekkdv.Clear();
            odenemesigerekenkdv.Clear();
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vergidairesi.Clear();
            vergikimlikno.Clear();
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
            yurtdisinayapilanodeme.Clear();
            serinoluodeme.Clear();
            geneltoplam.Clear();
            // 3.bölüm
            tamtevfikatvergitoplami.Clear();
            kismivergitoplami.Clear();
            kdvmatrah.Clear();
            tevkifedilenkdv.Clear();
            ilaveedilecekkdv.Clear();
            odenemesigerekenkdv.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void kapartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form45_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet22.kdvikikismitevfikatorani' table. You can move, or remove it, as needed.
            this.kdvikikismitevfikatoraniTableAdapter.Fill(this.mhsbdataDataSet22.kdvikikismitevfikatorani);
            // TODO: This line of code loads data into the 'mhsbdataDataSet21.kdvikitamtevfikatuygulananislemler' table. You can move, or remove it, as needed.
            this.kdvikitamtevfikatuygulananislemlerTableAdapter.Fill(this.mhsbdataDataSet21.kdvikitamtevfikatuygulananislemler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet20.kdvikikdvkesintisiyapilanlaraaitbildirim' table. You can move, or remove it, as needed.
            this.kdvikikdvkesintisiyapilanlaraaitbildirimTableAdapter.Fill(this.mhsbdataDataSet20.kdvikikdvkesintisiyapilanlaraaitbildirim);

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
            Form80 a = new Form80();
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
