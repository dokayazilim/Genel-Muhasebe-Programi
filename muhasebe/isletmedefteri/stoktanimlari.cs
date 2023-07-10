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
    public partial class stoktanimlari : Form
    {
        public stoktanimlari()
        {
            InitializeComponent();
        }

        private void stoktanimlari_Load(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarstok.accdb";
                con.Open();

                string komut = "Delete from stoktanimlari";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                con.Close();







            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarstokDataSet3.stoktanimlari' table. You can move, or remove it, as needed.
            this.stoktanimlariTableAdapter.Fill(this.muhasebeortakhesaplarstokDataSet3.stoktanimlari);

        }

        private void button1_Click(object sender, EventArgs e)
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
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarstok.accdb");
                    baglanti.Open();

                    OleDbCommand kayit = new OleDbCommand();
                    kayit.CommandText = "INSERT INTO stoktanimlari(stokkodu,stokadi,grubu,birimi,aciklama,dsmmhesabialis,maliyethesabi) Values('" + stokkodu.Text + "','" + stokadi.Text + "','" + grubu.Text + "','" + birimi.Text + "','" + aciklama.Text + "','" + dsmm.Text + "','" + maliyethesabi.Text + "')";
                    kayit.Connection = baglanti;
                    kayit.ExecuteNonQuery();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti ve tabloya aktarıldı.", "Stok Tanımları");


                }
                catch (OleDbException ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

        }
        public void listele()
        {

            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=muhasebeortakhesaplarstok.accdb");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from stoktanimlari", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi yapılmamaktadır.","Deneme Sürümü");
        }

        private void excelEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran, ran2;
            ran = shee.get_Range("A1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Stok Kodu");
            ran2 = shee.get_Range("B1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Stok Adı");
            ran2 = shee.get_Range("C1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Grubu");
            ran2 = shee.get_Range("D1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Birimi");
            ran2 = shee.get_Range("E1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran2 = shee.get_Range("F1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "DSMM Hesabı");
            ran2 = shee.get_Range("A3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Maliyet Hesabı");
            ran = shee.get_Range("A2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, stokkodu.Text);
            ran2 = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, stokadi.Text);
            ran2 = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, grubu.Text);
            ran2 = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, birimi.Text);
            ran2 = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, aciklama.Text);
            ran2 = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, dsmm.Text);
            ran2 = shee.get_Range("A4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, maliyethesabi.Text);
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
