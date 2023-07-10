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
    public partial class Form49 : Form
    {
        public Form49()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void kapartToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void label31_Click(object sender, EventArgs e)
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
            // 2.bölüm
            ticarikazanczarar.Clear();
            yatirimindirimizarar.Clear();
            istisnalarzarar.Clear();
            serbestmeslekkazanci.Clear();
            zarartoplami.Clear();
            zarar.Clear();
            mahsupedilecekzarar.Clear();
            ticarikazanczarar.Clear();
            kalanticarikar.Clear();
            serbestmeslekkar.Clear();
            kartoplami.Clear();
            kar.Clear();
            ticarikazanckar.Clear();
            indirimeesastutarkar.Clear();
            indirimlertoplam.Clear();
            indirimlerdonemzarari.Clear();
            gecicivergimatrahi.Clear();
            // 3.bölüm
            vergi1.Clear();
            vergi2.Clear();
            vergi3.Clear();
            vergi4.Clear();
            vergi5.Clear();
            vergi6.Clear();
            vergi7.Clear();
            vergi8.Clear();
            vergi9.Clear();

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
            // 2.bölüm
            ticarikazanczarar.Clear();
            yatirimindirimizarar.Clear();
            istisnalarzarar.Clear();
            serbestmeslekkazanci.Clear();
            zarartoplami.Clear();
            zarar.Clear();
            mahsupedilecekzarar.Clear();
            ticarikazanczarar.Clear();
            kalanticarikar.Clear();
            serbestmeslekkar.Clear();
            kartoplami.Clear();
            kar.Clear();
            ticarikazanckar.Clear();
            indirimeesastutarkar.Clear();
            indirimlertoplam.Clear();
            indirimlerdonemzarari.Clear();
            gecicivergimatrahi.Clear();
            // 3.bölüm
            vergi1.Clear();
            vergi2.Clear();
            vergi3.Clear();
            vergi4.Clear();
            vergi5.Clear();
            vergi6.Clear();
            vergi7.Clear();
            vergi8.Clear();
            vergi9.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form49_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet29.gecicivergibeyannamesivergibildirimi' table. You can move, or remove it, as needed.
            this.gecicivergibeyannamesivergibildirimiTableAdapter.Fill(this.mhsbdataDataSet29.gecicivergibeyannamesivergibildirimi);
            // TODO: This line of code loads data into the 'mhsbdataDataSet28.gecicivergibeyannamesiindirimler' table. You can move, or remove it, as needed.
            this.gecicivergibeyannamesiindirimlerTableAdapter.Fill(this.mhsbdataDataSet28.gecicivergibeyannamesiindirimler);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Deneme sürümünde beyanname kaydı yapılamaz veya gönderilemez.", "Uyarı");

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");


        }

        private void xMLEOlarakKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form84 a = new Form84();
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
