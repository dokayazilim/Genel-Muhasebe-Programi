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
    public partial class Form51 : Form
    {
        public Form51()
        {
            InitializeComponent();
        }

        private void Form51_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet31.yillikgelirvergisibeyannamesibeyanedilecekgelirlerdenindirim' table. You can move, or remove it, as needed.
            this.yillikgelirvergisibeyannamesibeyanedilecekgelirlerdenindirimTableAdapter.Fill(this.mhsbdataDataSet31.yillikgelirvergisibeyannamesibeyanedilecekgelirlerdenindirim);

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

        private void label32_Click(object sender, EventArgs e)
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
            isletmehesabi.Checked = false;
            serbestmeslek.Checked = false;
            gelirveyagayrisafi.Clear();
            giderveyaindirilecek.Clear();
            finansmangiderleri.Clear();
            amortismanbilgileri.Clear();
            //3. bölüm
            ticarikazanczarar.Clear();
            ziraikazanczarar.Clear();
            serbestmeslekzarar.Clear();
            gayrimenkulsermayezarar.Clear();
            menkulsermayezarar.Clear();
            toplamzarar.Clear();
            zarar.Clear();
            ucretlerkar.Clear();
            digerkazanckar.Clear();
            mahsupedilecektoplam.Clear();
            ticarikazanckar.Clear();
            ziraikazanckar.Clear();
            serbestmeslekkar.Clear();
            gayrimenkulsermayekar.Clear();
            menkulsermayekar.Clear();
            toplamkar.Clear();
            kar.Clear();
            mahsupedilecekindirim.Clear();
            mahsupsonrasikalan.Clear();
            sayilikanun.Clear();
            // 4.bölüm
            vergiyetabi.Clear();
            hesaplamagelirvergisi.Clear();
            yabanciulkedeodenenvergiler.Clear();
            kesintiyoluylaodenenvergiler.Clear();
            gecicivergiler.Clear();
            asgarigecim.Clear();
            mahsupedilecekvergilertoplami.Clear();
            odenmesigerekenvergi.Clear();
            iadesigerekengelirvergisi.Clear();
            iadesigerekengecicivergi.Clear();
            odenmesigerekendamgavergisi.Clear();
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
            isletmehesabi.Checked = false;
            serbestmeslek.Checked = false;
            gelirveyagayrisafi.Clear();
            giderveyaindirilecek.Clear();
            finansmangiderleri.Clear();
            amortismanbilgileri.Clear();
            //3. bölüm
            ticarikazanczarar.Clear();
            ziraikazanczarar.Clear();
            serbestmeslekzarar.Clear();
            gayrimenkulsermayezarar.Clear();
            menkulsermayezarar.Clear();
            toplamzarar.Clear();
            zarar.Clear();
            mahsupedilecektoplam.Clear();
            ticarikazanckar.Clear();
            ziraikazanckar.Clear();
            serbestmeslekkar.Clear();
            gayrimenkulsermayekar.Clear();
            menkulsermayekar.Clear();
            toplamkar.Clear();
            kar.Clear();
            mahsupedilecekindirim.Clear();
            mahsupsonrasikalan.Clear();
            sayilikanun.Clear();
            // 4.bölüm
            vergiyetabi.Clear();
            hesaplamagelirvergisi.Clear();
            yabanciulkedeodenenvergiler.Clear();
            kesintiyoluylaodenenvergiler.Clear();
            gecicivergiler.Clear();
            asgarigecim.Clear();
            mahsupedilecekvergilertoplami.Clear();
            odenmesigerekenvergi.Clear();
            iadesigerekengelirvergisi.Clear();
            iadesigerekengecicivergi.Clear();
            odenmesigerekendamgavergisi.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            Form86 a = new Form86();
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
