using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace isletmedefteri
{
    public partial class carihesap : Form
    {
        public carihesap()
        {
            InitializeComponent();
        }

        private void carihesap_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarcari.accdb";
                con.Open();

                string komut = "Delete from carihesaplar";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                con.Close();          

                           





            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarcariDataSet4.carihesaplar' table. You can move, or remove it, as needed.
            this.carihesaplarTableAdapter1.Fill(this.muhasebeortakhesaplarcariDataSet4.carihesaplar);
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {
                if (tckimlik.Text == "")
                {
                    MessageBox.Show("T.C. Kimlik alanı boş geçilemez.", "Uyarı");
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




                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());

                    }
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

        private void button5_Click(object sender, EventArgs e)
        {
            string col2, col3;

            col2 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            


            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarcari.accdb";
                con.Open();

                string komut = "Update carihesaplar set borc='" + Convert.ToString(col2 + " TL") + "', alacak='" + Convert.ToString(col3 + " TL") + "' Where tckimlik='" + tckimlik.Text + "'";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                con.Close();
                listele();

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");



            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {
                if (tckimlik.Text == "")
                {
                    MessageBox.Show("T.C. Kimlik alanı boş geçilemez.", "Uyarı");
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




                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.ToString());

                    }
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
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tckimlik.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }

        }

        private void adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void tckimlik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void il_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void ilce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void postakodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void ulke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void telalan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void faxalan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void fax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void eposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void vergidairesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void website_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void yetkili_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void yetkiligorev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void adresno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void adres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void not1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult sonuc = MessageBox.Show("Kayıt silinecek. Emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (sonuc == DialogResult.Yes)
             {

                 try
                 {
                     OleDbConnection con = new OleDbConnection();
                     con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarcari.accdb";
                     con.Open();

                     string komut = "Delete from carihesaplar where tckimlik='" + tckimlik.Text + "'";

                     OleDbCommand komutsatir = new OleDbCommand(komut, con);
                     komutsatir.ExecuteNonQuery();
                     con.Close();
                     listele();


                     MessageBox.Show("Kaydınız silindi!", "Kayıt İşlemi");





                 }

                 catch (OleDbException ex)
                 {
                     MessageBox.Show(ex.ToString());
                 }
             }
        }

        private void carihesap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                button1.PerformClick();
            }
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }
    }
}
