using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace muhasebe
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
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

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplar.accdb";
                con.Open();

                string komut = "Delete from fisler";      // tablodaki bilgiler siliniyor...

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                con.Close();



            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarDataSet3.fisler' table. You can move, or remove it, as needed.
            this.fislerTableAdapter.Fill(this.muhasebeortakhesaplarDataSet3.fisler);
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fisno.Clear();
            evrakno.Clear();
            
            hesapkodu.Clear();
          
            
            
           
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fisno.Clear();
            evrakno.Clear();
            
            hesapkodu.Clear();
         
           
            
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void excelEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string col6;
            col6 = dataGridView1[12, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama...

            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran;
            ran = shee.get_Range("A1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Fiş Tarihi");
            ran = shee.get_Range("B1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Fiş No");
            ran = shee.get_Range("C1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Evrak No");
            ran = shee.get_Range("D1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Madde No");
            ran = shee.get_Range("E1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Hesap Kodu");
            ran = shee.get_Range("F1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran = shee.get_Range("A2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, fistarihi.Text);
            ran = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, fisno.Text);
            ran = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, evrakno.Text);
           
            ran = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, hesapkodu.Text);
            ran = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string col1, col2, col3, col4, col5, col6;
            col1 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // belge türü..
            col2 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // vergi dairesi..
            col3 = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar
            col4 = dataGridView1[10, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // borç
            col5 = dataGridView1[11, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // alacak..
            col6 = dataGridView1[12, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama...

            
            float brc = float.Parse(col4);
            float alck = float.Parse(col5);
            float kdv, kdv2;

            col4 = (brc + ((brc * 18) / 100)).ToString();
            col5 = (alck + ((alck * 18) / 100)).ToString();

            kdv = (brc * 18) / 100;
            kdv2 = (alck * 18) / 100;

            if ((hesapkodu.Text == "100") || (hesapkodu.Text == "101") || (hesapkodu.Text == "102") || (hesapkodu.Text == "103") || (hesapkodu.Text == "108"))
            {
                if (col4 != "")
                {
                    if (col5 != "")
                    {
                        try
                        {
                            OleDbConnection con = new OleDbConnection();
                            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplar.accdb";
                            con.Open();

                            string komut = "Update fisler set BelgeTuru='" + Convert.ToString(col1) + "', VergiDairesi='" + Convert.ToString(col2) + "', Miktar='" + Convert.ToString(col3) + "', Borc='" + Convert.ToString(col4) + "', Alacak='" + Convert.ToString(col5) + "', Aciklama='" + Convert.ToString(col6) + "' Where FisTarihi='" + fistarihi.Text + "'";

                            OleDbCommand komutsatir = new OleDbCommand(komut, con);
                            komutsatir.ExecuteNonQuery();
                            string komut2 = "INSERT INTO fisler(HesapKodu,Borc,Alacak)VALUES('" + "191.01" + "','" + kdv + "','" + "" + "')";

                            OleDbCommand komutsatir2 = new OleDbCommand(komut2, con);
                            komutsatir2.ExecuteNonQuery();

                            string komut3 = "INSERT INTO fisler(HesapKodu,Borc,Alacak)VALUES('" + "391.18" + "','" + "" + "','" + kdv2 + "')";

                            OleDbCommand komutsatir3 = new OleDbCommand(komut3, con);
                            komutsatir3.ExecuteNonQuery();
                            con.Close();
                            listele();

                            MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");








                        }

                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if ((hesapkodu.Text == ""))
            {
                MessageBox.Show("Hesap Kodu değeri boş geçilemez.", "Uyarı");
            }
            else
            {
                //float kdv = float.Parse(kdvlistesi.Text);
                //float brc = float.Parse(borc.Text);
                //float alck = float.Parse(alacak.Text);

                //borc.Text = (brc + ((brc * kdv) / 100)).ToString();
                //alacak.Text = (alck + ((alck * kdv) / 100)).ToString();

                try
                {
                    OleDbConnection baglanti;
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplar.accdb");
                    baglanti.Open();

                    OleDbCommand kayit = new OleDbCommand();
                    kayit.CommandText = "INSERT INTO fisler(FisTarihi,FisNo,EvrakNo,MaddeNo,HesapKodu,FirmaKodu,StokKodu)VALUES('" + fistarihi.Text + "','" + fisno.Text + "','" + evrakno.Text + "','" + "1" + "','" + hesapkodu.Text + "','" + "2" + "','" + "3" + "')";
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

        public void listele()
        {

            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplar.accdb");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from fisler", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form64 a = new Form64();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form53 a = new Form53();
            a.Show();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!","Uyarı");
        }

        private void xMLKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
        }

        private void eskiFişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (eskifislerekaydet.Checked)
            {
                string col6;
                col6 = dataGridView1[12, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama...
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdigerhesaplar.mdf;Integrated Security=True";
                    con.Open();

                    string komut = "INSERT INTO eskifisler(FisTarihi,FisTipi,FisNo,EvrakNo,BorcToplami,AlacakToplami,Bakiye,Aciklama)VALUES('" + fistarihi.Text + "','" + "Tahsil Fişi" + "','" + fisno.Text + "','" + evrakno.Text + "','" + alacaktoplami.Text + "','" + borctoplami.Text + "','" + bakiyetoplami.Text + "','" + col6 + "')";

                    SqlCommand komutsatir = new SqlCommand(komut, con);
                    komutsatir.ExecuteNonQuery();

                    MessageBox.Show("Eski Fişlere kaydedildi!", "Eski Fişler");


                }

                catch (SqlException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
            else
            {


                if (dataGridView1.RowCount >= 6)
                {
                    MessageBox.Show("Deneme sürümü burada sona erdi! İlginize teşekkür ederiz.", "Deneme Sürümü");
                }
                else
                {
                    if ((hesapkodu.Text == ""))
                    {
                        MessageBox.Show("Hesap Kodu değeri boş geçilemez.", "Uyarı");
                    }
                    else
                    {
                        //float kdv = float.Parse(kdvlistesi.Text);
                        //float brc = float.Parse(borc.Text);
                        //float alck = float.Parse(alacak.Text);

                        //borc.Text = (brc + ((brc * kdv) / 100)).ToString();
                        //alacak.Text = (alck + ((alck * kdv) / 100)).ToString();

                        try
                        {
                            SqlConnection con = new SqlConnection();
                            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                            con.Open();

                            string komut = "INSERT INTO acilisfisi(FisTarihi,FisNo,EvrakNo,MaddeNo,HesapKodu,FirmaKodu,StokKodu)VALUES('" + fistarihi.Text + "','" + fisno.Text + "','" + evrakno.Text + "','" + "1" + "','" + hesapkodu.Text + "','" + "2" + "','" + "3" + "')";

                            SqlCommand komutsatir = new SqlCommand(komut, con);
                            komutsatir.ExecuteNonQuery();
                            listele();
                        }

                        catch (SqlException ex)
                        {

                            MessageBox.Show(ex.ToString());


                        }




                    }
                }
            }*/



            if ((hesapkodu.Text == ""))
            {
                MessageBox.Show("Hesap Kodu değeri boş geçilemez.", "Uyarı");
            }
            else
            {
                //float kdv = float.Parse(kdvlistesi.Text);
                //float brc = float.Parse(borc.Text);
                //float alck = float.Parse(alacak.Text);

                //borc.Text = (brc + ((brc * kdv) / 100)).ToString();
                //alacak.Text = (alck + ((alck * kdv) / 100)).ToString();

                try
                {
                    OleDbConnection baglanti;
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplar.accdb");
                    baglanti.Open();

                    OleDbCommand kayit = new OleDbCommand();
                    kayit.CommandText = "INSERT INTO fisler(FisTarihi,FisNo,EvrakNo,MaddeNo,HesapKodu,FirmaKodu,StokKodu)VALUES('" + fistarihi.Text + "','" + fisno.Text + "','" + evrakno.Text + "','" + "1" + "','" + hesapkodu.Text + "','" + "2" + "','" + "3" + "')";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }

        private void fisno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void evrakno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void maddeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void hesapkodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void firmakodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void stokkodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void kdvlistesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                button2.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button4.PerformClick();
            } 
        }

        private void ayarlarıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayarlar a = new ayarlar();
            a.Show();
        }

        private void hesapkodu_TextChanged(object sender, EventArgs e)
        {
            Form61 a = new Form61();
            a.Show();
        }
     
   
    }
}
