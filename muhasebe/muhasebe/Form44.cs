using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace muhasebe
{
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
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
            tevfikatuygulanmayantoplam.Clear();
            kismitevfikat.Clear();
            vergitoplami.Clear();
            toplammatrah.Clear();
            hesaplanankdv.Clear();
            ilaveedilecek.Clear();
            toplamkdv.Clear();
            // 3. bölüm
            indirimvergitoplami.Clear();
            donemtoplami.Clear();
            donemtoplami2.Clear();
            // 4. bölüm
            teciledilebilirkdv.Clear();
            ihracatingerceklestigidonem.Clear();
            indirimlioranatabi.Clear();
            // 5. bölüm
            kismitoplam.Clear();
            kismitoplam2.Clear();
            istisnatoplam.Clear();
            istisnatoplam2.Clear();
            istisnakapsaminagirenislemler.Clear();
            toplam1.Clear();
            toplam2.Clear();
            iadeedilebilirkdvtoplami.Clear();
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
            tevfikatuygulanmayantoplam.Clear();
            kismitevfikat.Clear();
            vergitoplami.Clear();
            toplammatrah.Clear();
            hesaplanankdv.Clear();
            ilaveedilecek.Clear();
            toplamkdv.Clear();
            // 3. bölüm
            indirimvergitoplami.Clear();
            donemtoplami.Clear();
            donemtoplami2.Clear();
            // 4. bölüm
            teciledilebilirkdv.Clear();
            ihracatingerceklestigidonem.Clear();
            indirimlioranatabi.Clear();
            // 5. bölüm
            kismitoplam.Clear();
            kismitoplam2.Clear();
            istisnatoplam.Clear();
            istisnatoplam2.Clear();
            istisnakapsaminagirenislemler.Clear();
            toplam1.Clear();
            toplam2.Clear();
            iadeedilebilirkdvtoplami.Clear();
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            



            
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            




        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            


            MessageBox.Show("İşlemleriniz başarıyla kaydedildi ve listelendi!", "Kayıt İşlemi");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void Form44_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet19.kdvbirekler' table. You can move, or remove it, as needed.
            this.kdvbireklerTableAdapter.Fill(this.mhsbdataDataSet19.kdvbirekler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet18.kdvbirdigeriadehakki' table. You can move, or remove it, as needed.
            this.kdvbirdigeriadehakkiTableAdapter.Fill(this.mhsbdataDataSet18.kdvbirdigeriadehakki);
            // TODO: This line of code loads data into the 'mhsbdataDataSet17.kdvbirtamistisnakapsami' table. You can move, or remove it, as needed.
            this.kdvbirtamistisnakapsamiTableAdapter.Fill(this.mhsbdataDataSet17.kdvbirtamistisnakapsami);
            // TODO: This line of code loads data into the 'mhsbdataDataSet16.kdvbirkismiistisnakapsami' table. You can move, or remove it, as needed.
            this.kdvbirkismiistisnakapsamiTableAdapter.Fill(this.mhsbdataDataSet16.kdvbirkismiistisnakapsami);
            // TODO: This line of code loads data into the 'mhsbdataDataSet15.kdvbirihrackaydiylateslimler' table. You can move, or remove it, as needed.
            this.kdvbirihrackaydiylateslimlerTableAdapter.Fill(this.mhsbdataDataSet15.kdvbirihrackaydiylateslimler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet14.kdvbirindirilecekkdv' table. You can move, or remove it, as needed.
            this.kdvbirindirilecekkdvTableAdapter.Fill(this.mhsbdataDataSet14.kdvbirindirilecekkdv);
            // TODO: This line of code loads data into the 'mhsbdataDataSet13.kdvbirindirimler' table. You can move, or remove it, as needed.
            this.kdvbirindirimlerTableAdapter.Fill(this.mhsbdataDataSet13.kdvbirindirimler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet12.kdvbirdigerislemler' table. You can move, or remove it, as needed.
            this.kdvbirdigerislemlerTableAdapter.Fill(this.mhsbdataDataSet12.kdvbirdigerislemler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet11.kdvbirkismitevfikatuygulananislemler' table. You can move, or remove it, as needed.
            this.kdvbirkismitevfikatuygulananislemlerTableAdapter.Fill(this.mhsbdataDataSet11.kdvbirkismitevfikatuygulananislemler);
            // TODO: This line of code loads data into the 'mhsbdataDataSet10.kdvbirtevfikatuygulanmayanislemler' table. You can move, or remove it, as needed.
            this.kdvbirtevfikatuygulanmayanislemlerTableAdapter.Fill(this.mhsbdataDataSet10.kdvbirtevfikatuygulanmayanislemler);

            

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            

            
            
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView2_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde beyanname kaydı yapılamaz veya gönderilemez.","Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form79 a = new Form79();
            a.Show();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void xMLEOlarakKaydwrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
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
