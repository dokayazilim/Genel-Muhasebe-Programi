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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarDataSet5.gidersayfasi' table. You can move, or remove it, as needed.
            this.gidersayfasiTableAdapter4.Fill(this.isletmedefteriortakhesaplarDataSet5.gidersayfasi);
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarkayitDataSet2.gidersayfasi' table. You can move, or remove it, as needed.
            this.gidersayfasiTableAdapter3.Fill(this.isletmedefteriortakhesaplarkayitDataSet2.gidersayfasi);
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarkayitDataSet1.gidersayfasi' table. You can move, or remove it, as needed.
            this.gidersayfasiTableAdapter2.Fill(this.isletmedefteriortakhesaplarkayitDataSet1.gidersayfasi);
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarDataSet4.hesapplani' table. You can move, or remove it, as needed.
            this.hesapplaniTableAdapter1.Fill(this.isletmedefteriortakhesaplarDataSet4.hesapplani);
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarDataSet3.sabitkiymetler' table. You can move, or remove it, as needed.
            this.sabitkiymetlerTableAdapter.Fill(this.isletmedefteriortakhesaplarDataSet3.sabitkiymetler);
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarDataSet2.gidersayfasi' table. You can move, or remove it, as needed.
            this.gidersayfasiTableAdapter1.Fill(this.isletmedefteriortakhesaplarDataSet2.gidersayfasi);
            // TODO: This line of code loads data into the 'isletmedefteriortakhesaplarDataSet1.gelirsayfasi' table. You can move, or remove it, as needed.
            this.gelirsayfasiTableAdapter1.Fill(this.isletmedefteriortakhesaplarDataSet1.gelirsayfasi);
         

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            stoktanimlari a = new stoktanimlari();
            a.Show();
        }

        private void hesapMakineisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıtlarda stoklu mal girişi yapılmamış.","Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defterkayitlifirma a = new defterkayitlifirma();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            defterkayitlifirma2 a = new defterkayitlifirma2();
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            defterkayitlifirma4 a = new defterkayitlifirma4();
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıt silinecek. Emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                string col2;
                col2 = dataGridView3[2, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // belge tarihi...
                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb";
                    con.Open();

                    string komut = "Delete from sabitkiymetler where belgetarihi='" + col2 + "'";

                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    komutsatir.ExecuteNonQuery();
                    con.Close();
                    listele3();


                    MessageBox.Show("Kaydınız silindi!", "Kayıt İşlemi");





                }

                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {

                if (belgeno.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {
                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gelirsayfasi(tarih,belgeno)VALUES('" + tarih.Text + "','" + belgeno.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele();


                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }
        public void listele()
        {
            OleDbConnection baglanti;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
            DataTable tablo = new DataTable();
            tablo.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select * from gelirsayfasi", baglanti);
            adpt.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6,col7,col8;
            
            col2 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

            int cl1 = int.Parse(col5);
            int cl2 = int.Parse(col6);
            
            int kdvsi = (cl1 * cl2)/100;
            int toplam = cl2 + kdvsi;
            

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb";
                con.Open();

                string komut = "Update gelirsayfasi set belgeno='" + belgeno.Text + "', aciklama='" + Convert.ToString(col2) + "', miktar='" + Convert.ToString(col3) + "', islem='" + Convert.ToString(col4) + "', kdv='" + Convert.ToString(col5) + "', kdvsiztutar='" + Convert.ToString(col6) + "', kdvlitutar='" + Convert.ToString(kdvsi) + "', toplamtutar='" + Convert.ToString(toplam) + "' Where belgeno='" + belgeno.Text + "'";
                string kmt = "Select sum(toplamtutar) from gelirsayfasi";
                string kmt2 = "Select sum(kdvsiztutar) from gelirsayfasi";
                string kmt3 = "Select sum(kdvlitutar) from gelirsayfasi";
                string kmt4 = "Select sum(kdvlitutar) from gelirsayfasi";
                OleDbCommand komutsatir = new OleDbCommand(komut,con);
                
                
                komutsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir = new OleDbCommand(kmt, con); 
                double sonuc = Convert.ToDouble(kmtsatir.ExecuteScalar());
                geneltoplam.Text = sonuc.ToString("c");
                kmtsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir2 = new OleDbCommand(kmt2, con);
                double sonuc2 = Convert.ToDouble(kmtsatir2.ExecuteScalar());
                toplamtutari.Text = sonuc2.ToString("c");
                kmtsatir2.ExecuteNonQuery();
                OleDbCommand kmtsatir3 = new OleDbCommand(kmt3, con);
                double sonuc3 = Convert.ToDouble(kmtsatir3.ExecuteScalar());
                kdvtoplami.Text = sonuc3.ToString("c");
                kmtsatir3.ExecuteNonQuery();
                OleDbCommand kmtsatir4 = new OleDbCommand(kmt4, con);
                double sonuc4 = Convert.ToDouble(kmtsatir4.ExecuteScalar());
                hasilatkdv.Text = sonuc4.ToString("c");
                kmtsatir4.ExecuteNonQuery();
                con.Close();
                oncekidonemtoplami.Text = "0,00 TL";
                listele();

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");

              

            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void tarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void hesapkodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        /*public void listele2()
        {
            OleDbConnection baglanti2;
            baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
            DataTable tablo2 = new DataTable();
            tablo2.Clear();

            OleDbDataAdapter adpt2 = new OleDbDataAdapter("Select * from gidersayfasi", baglanti2);
            adpt2.Fill(tablo2);
            dataGridView1.DataSource = tablo2;

        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6, col7, col8;
            
            col2 = dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView2[7, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView2[8, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

            int cl1 = int.Parse(col5);
            int cl2 = int.Parse(col6);

            int kdvsi = (cl1 * cl2) / 100;
            int toplam = cl2 + kdvsi;

            

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb";
                con.Open();

                string komut = "Update gidersayfasi set belgeno='" + belgenogider.Text + "', aciklama='" + Convert.ToString(col2) + "', miktar='" + Convert.ToString(col3) + "', islem='" + Convert.ToString(col4) + "', kdv='" + Convert.ToString(col5) + "', kdvsiztutar='" + Convert.ToString(col6) + "', kdvlitutar='" + Convert.ToString(kdvsi) + "', toplamtutar='" + Convert.ToString(toplam) + "' Where belgeno='" + belgenogider.Text + "'";
                string kmt = "Select sum(toplamtutar) from gidersayfasi";
                string kmt2 = "Select sum(kdvsiztutar) from gidersayfasi";
                string kmt3 = "Select sum(kdvlitutar) from gidersayfasi";
                string kmt4 = "Select sum(kdvlitutar) from gidersayfasi";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir = new OleDbCommand(kmt, con);
                double sonuc = Convert.ToDouble(kmtsatir.ExecuteScalar());
                geneltoplamgider.Text = sonuc.ToString("c");
                kmtsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir2 = new OleDbCommand(kmt2, con);
                double sonuc2 = Convert.ToDouble(kmtsatir2.ExecuteScalar());
                toplamtutarigider.Text = sonuc2.ToString("c");
                kmtsatir2.ExecuteNonQuery();
                OleDbCommand kmtsatir3 = new OleDbCommand(kmt3, con);
                double sonuc3 = Convert.ToDouble(kmtsatir3.ExecuteScalar());
                kdvtoplamigider.Text = sonuc3.ToString("c");
                kmtsatir3.ExecuteNonQuery();
                OleDbCommand kmtsatir4 = new OleDbCommand(kmt4, con);
                double sonuc4 = Convert.ToDouble(kmtsatir4.ExecuteScalar());
                hasilatkdvgider.Text = sonuc4.ToString("c");
                kmtsatir4.ExecuteNonQuery();
                con.Close();
                oncekidonemgider.Text = "0,00 TL";
                listele2();

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");

              

            

            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void tarihgider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void hesapkodugider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {

                if (belgenogider.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {

                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gidersayfasi(tarih,belgeno)VALUES('" + tarihgider.Text + "','" + belgenogider.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele2();



                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
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
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
                    baglanti.Open();

                    OleDbCommand kayit = new OleDbCommand();
                    kayit.CommandText = "INSERT INTO sabitkiymetler(belgetarihi,faydaliomru,kistamortisman,belgetarihisatis)VALUES('" + belgetarihi.Text + "','" + suresi.Text + "','" + kistamortisman.Text + "','" + satisbelgetarihi.Text + "')";
                    kayit.Connection = baglanti;
                    kayit.ExecuteNonQuery();
                    baglanti.Close();
                    listele3();





                }
                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listele2()
        {
            OleDbConnection baglanti;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
            DataTable tablo = new DataTable();
            tablo.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select * from gidersayfasi", baglanti);
            adpt.Fill(tablo);
            dataGridView2.DataSource = tablo;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            belgetarihi.Clear();
            suresi.Clear();
            kistamortisman.SelectedIndex = -1;
            satisbelgetarihi.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11,col12;
            col1 = dataGridView3[0, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // kodu...
            col2 = dataGridView3[1, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // adı...
            col3 = dataGridView3[3, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // belge no...
            col4 = dataGridView3[4, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // belge açıklama...
            col5 = dataGridView3[5, dataGridView3.CurrentCell.RowIndex].Value.ToString();  // alış bedeli...
            col6 = dataGridView3[6, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // kdv tutarı...
            col7 = dataGridView3[9, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // amortisman yöntemi...
            col8 = dataGridView3[10, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // amortisman oranı...
            col9 = dataGridView3[12, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // belge numarası...
            col10 = dataGridView3[13, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // belge aciklamasi...
            col11 = dataGridView3[14, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // satış bedeli...
            col12 = dataGridView3[15, dataGridView3.CurrentCell.RowIndex].Value.ToString(); // satış kdv tutarı...
           





            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb";
                con.Open();

                string komut = "Update sabitkiymetler set kodu='" + Convert.ToString(col1) + "', adi='" + Convert.ToString(col2) + "', belgeno='" + Convert.ToString(col3) + "', belgeaciklama='" + Convert.ToString(col4) + "', alisbedeli='" + Convert.ToString(col5) + "', kdvtutari='" + Convert.ToString(col6) + "', amortismanyontemi='" + Convert.ToString(col7) + "', amortismanorani='" + Convert.ToString(col8) + "', belgenumarasi='" + Convert.ToString(col9) + "', belgeaciklamasi='" + Convert.ToString(col10) + "', satisbedeli='" + Convert.ToString(col11) + "', satiskdvtutari='" + Convert.ToString(col12) + "' Where belgetarihi='" + belgetarihi.Text + "'";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                con.Close();
                listele3();
                

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");





            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void belgetarihi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button12.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button10.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button13.PerformClick();
            }
            /*else if (e.KeyCode == Keys.Delete)
             {
                 button11.PerformClick();
             }*/ 
        }

        private void dataGridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button12.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button10.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button13.PerformClick();
            }
            /*else if (e.KeyCode == Keys.Delete)
            {
                button11.PerformClick();
            }*/ 
        }

        private void suresi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button12.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button10.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button13.PerformClick();
            }
            /*else if (e.KeyCode == Keys.Delete)
            {
                button11.PerformClick();
            }*/ 
        }

        private void kistamortisman_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button12.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button10.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button13.PerformClick();
            }
            /*else if (e.KeyCode == Keys.Delete)
             {
                 button11.PerformClick();
             }*/ 
        }

        private void satisbelgetarihi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button12.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button10.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button13.PerformClick();
            }
            /*else if (e.KeyCode == Keys.Delete)
             {
                 button11.PerformClick();
             }*/ 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6, col7, col8;

            col2 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar..

            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran;
            ran = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Tarih");
            ran = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "BelgeNo");
            ran = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Miktar");
            ran = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "İşlem");
            ran = shee.get_Range("B4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDV");
            ran = shee.get_Range("C4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Fiyat");
            ran = shee.get_Range("D4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDVsi");
            ran = shee.get_Range("E4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "ToplamTutar");
            ran = shee.get_Range("B3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, tarih.Text);
            ran = shee.get_Range("C3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, belgeno.Text);
            ran = shee.get_Range("D3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col2);
            ran = shee.get_Range("E3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col3);
            ran = shee.get_Range("F3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col4);
            ran = shee.get_Range("B5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col5);
            ran = shee.get_Range("C5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col6);
            ran = shee.get_Range("D5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col7);
            ran = shee.get_Range("E5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col8);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            BindingSource sr = new BindingSource();
            sr.DataSource = dataGridView4.DataSource;

            sr.Filter = "hesapaciklama like '%" + ara.Text + "%'";
            dataGridView4.DataSource = sr;
        }

        private void dataGridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button14.PerformClick();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {

                string col1, col2, col3, col4, col5, col6;
                col1 = dataGridView4[0, dataGridView4.CurrentCell.RowIndex].Value.ToString(); // hesap açıklama...
                col2 = dataGridView4[1, dataGridView4.CurrentCell.RowIndex].Value.ToString(); // gider işlem...
                col3 = dataGridView4[2, dataGridView4.CurrentCell.RowIndex].Value.ToString(); // gelir işlem
                col4 = dataGridView4[3, dataGridView4.CurrentCell.RowIndex].Value.ToString(); // birimi...
                col5 = dataGridView4[4, dataGridView4.CurrentCell.RowIndex].Value.ToString();  // kdv...
                col6 = dataGridView4[5, dataGridView4.CurrentCell.RowIndex].Value.ToString(); // ortalama kar hesabı...


                try
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb";
                    con.Open();

                    string komut = "INSERT INTO hesapplani(hesapaciklama,giderislem,gelirislem,birimi,kdv,ortkarhesabi)VALUES('" + col1 + "','" + col2 + "','" + col3 + "','" + col4 + "','" + col5 + "','" + col6 + "')";

                    OleDbCommand komutsatir = new OleDbCommand(komut, con);
                    komutsatir.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");





                }

                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi yapılamaz!","Uyarı");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string  col2, col3, col4, col5, col6, col7, col8;
           
            col2 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar..

            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran;
            ran = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Tarih");
            ran = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "BelgeNo");
            ran = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Miktar");
            ran = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "İşlem");
            ran = shee.get_Range("B4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDV");
            ran = shee.get_Range("C4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Fiyat");
            ran = shee.get_Range("D4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDVsi");
            ran = shee.get_Range("E4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "ToplamTutar");
            ran = shee.get_Range("B3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, tarih.Text);
            ran = shee.get_Range("C3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, belgeno.Text);
            ran = shee.get_Range("D3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col2);
            ran = shee.get_Range("E3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col3);
            ran = shee.get_Range("F3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col4);
            ran = shee.get_Range("B5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col5);
            ran = shee.get_Range("C5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col6);
            ran = shee.get_Range("D5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col7);
            ran = shee.get_Range("E5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col8);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void belgeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        public void listele3()
        {
            OleDbConnection baglanti;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
            DataTable tablo = new DataTable();
            tablo.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select * from sabitkiymetler", baglanti);
            adpt.Fill(tablo);
            dataGridView3.DataSource = tablo;

        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgeno.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();          
        }

        private void belgenogider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgenogider.Text=dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {


                if (belgeno.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {
                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gelirsayfasi(tarih,belgeno)VALUES('" + tarih.Text + "','" + belgeno.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele();


                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void kaydetGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount >= 6)
            {
                MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
            }
            else
            {


                if (belgenogider.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {

                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=isletmedefteriortakhesaplar.accdb");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gidersayfasi(tarih,belgeno)VALUES('" + tarihgider.Text + "','" + belgenogider.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele2();



                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

    }



}
