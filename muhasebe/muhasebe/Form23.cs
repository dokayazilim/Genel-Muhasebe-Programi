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

namespace muhasebe
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            grubu.Clear();
            birimi.SelectedIndex = -1;
            aciklama.Clear();
            dsmm.Clear();
            maliyethesabi.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
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

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet9.stoktanimlari' table. You can move, or remove it, as needed.
            this.stoktanimlariTableAdapter.Fill(this.mhsbdataDataSet9.stoktanimlari);

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
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                    con.Open();

                    string komut = "INSERT INTO stoktanimlari(StokKodu,StokAdi,Grubu,Birimi,Aciklama,DSMMHesabiAlis,MaliyetHesabi)VALUES('" + stokkodu.Text + "','" + stokadi.Text + "','" + grubu.Text + "','" + birimi.Text + "','" + aciklama.Text + "','" + dsmm.Text + "','" + maliyethesabi.Text + "')";

                    SqlCommand komutsatir = new SqlCommand(komut, con);
                    komutsatir.ExecuteNonQuery();

                    listele();

                    MessageBox.Show("Stok kaydı tamamlandı!", "Kayıt İşlemi");

                    stokkodu.Clear();
                    stokadi.Clear();
                    grubu.Clear();
                    birimi.SelectedIndex = -1;
                    aciklama.Clear();
                    dsmm.Clear();
                    maliyethesabi.Clear();

                }

                catch (SqlException ex)
                {

                    MessageBox.Show(ex.ToString());


                }
            }
            
        }
        public void listele()
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            dt.Clear();

            SqlDataAdapter adpt = new SqlDataAdapter("Select*from stoktanimlari", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void kayırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO stoktanimlari(StokKodu,StokAdi,Grubu,Birimi,Aciklama,DSMMHesabiAlis,MaliyetHesabi)VALUES('" + stokkodu.Text + "','" + stokadi.Text + "','" + grubu.Text + "','" + birimi.Text + "','" + aciklama.Text + "','" + dsmm.Text + "','" + maliyethesabi.Text + "')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();

                listele();

                MessageBox.Show("Stok kaydı tamamlandı!", "Kayıt İşlemi");

                stokkodu.Clear();
                stokadi.Clear();
                grubu.Clear();
                birimi.SelectedIndex = -1;
                aciklama.Clear();
                dsmm.Clear();
                maliyethesabi.Clear();

            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
            

            
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
