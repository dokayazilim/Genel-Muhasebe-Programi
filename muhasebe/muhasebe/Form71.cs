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

namespace muhasebe
{
    public partial class Form71 : Form
    {
        public Form71()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form71_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarcariDataSet3.carihesaplar' table. You can move, or remove it, as needed.
            this.carihesaplarTableAdapter1.Fill(this.muhasebeortakhesaplarcariDataSet3.carihesaplar);
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            soyadi.Clear();
            adi.Clear();
            tckimlik.Clear();
            il.Clear();
            ilce.Clear();
            postakodu.Clear();
            ulke.SelectedIndex = -1;
            telalan.Clear();
            tel.Clear();
            faxalan.Clear();
            fax.Clear();
            eposta.Clear();
            vergidairesi.Clear();
            website.Clear();
            yetkili.Clear();
            yetkiligorev.Clear();
            adresno.Clear();
            adres.Clear();
            not1.Clear();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {

                try
                {
                    OleDbConnection baglanti;
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarcari.accdb");
                    baglanti.Open();

                    OleDbCommand kayit = new OleDbCommand();
                    kayit.CommandText = "INSERT INTO carihesaplar(soyadi,adi,tckimlik,il,ilce,postakodu,ulke,telefon,fax,eposta,vergidaire,website,yetkili,yetkiligorev,adresno,adres,notes)VALUES('" + soyadi.Text + "','" + adi.Text + "','" + tckimlik.Text + "','" + il.Text + "','" + ilce.Text + "','" + postakodu.Text + "','" + ulke.Text + "','" + telalan.Text + "" + tel.Text + "','" + faxalan.Text + "" + fax.Text + "','" + eposta.Text + "','" + vergidairesi.Text + "','" + website.Text + "','" + yetkili.Text + "','" + yetkiligorev.Text + "','" + adresno.Text + "','" + adres.Text + "','" + not1.Text + "')";
                    kayit.Connection = baglanti;
                    kayit.ExecuteNonQuery();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("Kayıt başarıyla gerçekleşti ve listelendi!", "Cari Hesaplar");



                }
                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());

                }
            }
        }

        public void listele() 
        {
            OleDbConnection baglanti;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarcari.accdb");
            DataTable tablo = new DataTable();
            tablo.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select * from carihesaplar", baglanti);
            adpt.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form104 a = new Form104();
            a.Show();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {

                try
                {
                    OleDbConnection baglanti;
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarcari.accdb");
                    baglanti.Open();

                    OleDbCommand kayit = new OleDbCommand();
                    kayit.CommandText = "INSERT INTO carihesaplar(soyadi,adi,tckimlik,il,ilce,postakodu,ulke,telefon,fax,eposta,vergidaire,website,yetkili,yetkiligorev,adresno,adres,notes)VALUES('" + soyadi.Text + "','" + adi.Text + "','" + tckimlik.Text + "','" + il.Text + "','" + ilce.Text + "','" + postakodu.Text + "','" + ulke.Text + "','" + telalan.Text + "" + tel.Text + "','" + faxalan.Text + "" + fax.Text + "','" + eposta.Text + "','" + vergidairesi.Text + "','" + website.Text + "','" + yetkili.Text + "','" + yetkiligorev.Text + "','" + adresno.Text + "','" + adres.Text + "','" + not1.Text + "')";
                    kayit.Connection = baglanti;
                    kayit.ExecuteNonQuery();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("Kayıt başarıyla gerçekleşti ve listelendi!", "Cari Hesaplar");



                }
                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soyadi.Clear();
            adi.Clear();
            tckimlik.Clear();
            il.Clear();
            ilce.Clear();
            postakodu.Clear();
            ulke.SelectedIndex = -1;
            telalan.Clear();
            tel.Clear();
            faxalan.Clear();
            fax.Clear();
            eposta.Clear();
            vergidairesi.Clear();
            website.Clear();
            yetkili.Clear();
            yetkiligorev.Clear();
            adresno.Clear();
            adres.Clear();
            not1.Clear();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kayıt silme işlemi gerçekleştirilemez.","Uyarı");
        }
    }
}
