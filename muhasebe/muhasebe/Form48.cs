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
    public partial class Form48 : Form
    {
        public Form48()
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

        private void label35_Click(object sender, EventArgs e)
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
            matrahtoplam1.Clear();
            matrahtoplam2.Clear();
            ucret1.Clear();
            ucret2.Clear();
            ucret3.Clear();
            ucret4.Clear();
            ucret5.Clear();
            kvk.Clear();
            menkulkiymet.Clear();
            asgarigecim.Clear();
            mahsupedilecektoplamvergi.Clear();
            tevfikatailiskindamgavergisi.Clear();
            // 3. bölüm
            tahakkukmatrah.Clear();
            tahakkukeden.Clear();
            tahakkukiadeedilecek.Clear();
            tahakkukodenecekdamgavergisi.Clear();
            tahakkuktecil.Clear();
            tahakkukmahsup.Clear();
            tahakkukodenecekvergi.Clear();
            // 4. bölüm
            tevfikattoplam.Clear();
            tevfikattoplam2.Clear();
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
            matrahtoplam1.Clear();
            matrahtoplam2.Clear();
            ucret1.Clear();
            ucret2.Clear();
            ucret3.Clear();
            ucret4.Clear();
            ucret5.Clear();
            kvk.Clear();
            menkulkiymet.Clear();
            asgarigecim.Clear();
            mahsupedilecektoplamvergi.Clear();
            tevfikatailiskindamgavergisi.Clear();
            // 3. bölüm
            tahakkukmatrah.Clear();
            tahakkukeden.Clear();
            tahakkukiadeedilecek.Clear();
            tahakkukodenecekdamgavergisi.Clear();
            tahakkuktecil.Clear();
            tahakkukmahsup.Clear();
            tahakkukodenecekvergi.Clear();
            // 4. bölüm
            tevfikattoplam.Clear();
            tevfikattoplam2.Clear();
        }

        private void temizleToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            matrahtoplam1.Clear();
            matrahtoplam2.Clear();
            ucret1.Clear();
            ucret2.Clear();
            ucret3.Clear();
            ucret4.Clear();
            ucret5.Clear();
            kvk.Clear();
            menkulkiymet.Clear();
            asgarigecim.Clear();
            mahsupedilecektoplamvergi.Clear();
            tevfikatailiskindamgavergisi.Clear();
            // 3. bölüm
            tahakkukmatrah.Clear();
            tahakkukeden.Clear();
            tahakkukiadeedilecek.Clear();
            tahakkukodenecekdamgavergisi.Clear();
            tahakkuktecil.Clear();
            tahakkukmahsup.Clear();
            tahakkukodenecekvergi.Clear();
            // 4. bölüm
            tevfikattoplam.Clear();
            tevfikattoplam2.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form48_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet27.muhtasarbeyannameodemeler' table. You can move, or remove it, as needed.
            this.muhtasarbeyannameodemelerTableAdapter.Fill(this.mhsbdataDataSet27.muhtasarbeyannameodemeler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet26.muhtasarbeyannametahsilatiyapilmiskaldirilanvergiler' table. You can move, or remove it, as needed.
            this.muhtasarbeyannametahsilatiyapilmiskaldirilanvergilerTableAdapter.Fill(this.mhsbdataDataSet26.muhtasarbeyannametahsilatiyapilmiskaldirilanvergiler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet25.muhtasarbeyannamematrahvevergibildirimi' table. You can move, or remove it, as needed.
            this.muhtasarbeyannamematrahvevergibildirimiTableAdapter.Fill(this.mhsbdataDataSet25.muhtasarbeyannamematrahvevergibildirimi);

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
            Form83 a = new Form83();
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
