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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet1.kiratanimlariaylikodemebilgileri' table. You can move, or remove it, as needed.
            this.kiratanimlariaylikodemebilgileriTableAdapter.Fill(this.mhsbortakDataSet1.kiratanimlariaylikodemebilgileri);
            // TODO: This line of code loads data into the 'mhsbdataDataSet6.kiratanimlari' table. You can move, or remove it, as needed.
            this.kiratanimlariTableAdapter.Fill(this.mhsbdataDataSet6.kiratanimlari);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            aciklama.Clear();
            kiraucret.Clear();
            stopaj.Clear();
            sadi.Clear();
            skimlik.Clear();
            smeslegi.Clear();
            sadres.Clear();
            mbrut.Clear();
            mstopaj.Clear();
            msucret.Clear();
            msodeme.Clear();
            mhskayit.Checked = false;
            sectigimguntxt.Clear();
            sectigimgun.Checked = false;
            herayinsongunu.Checked = false;
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aciklama.Clear();
            kiraucret.Clear();
            stopaj.Clear();
            sadi.Clear();
            skimlik.Clear();
            smeslegi.Clear();
            sadres.Clear();
            mbrut.Clear();
            mstopaj.Clear();
            msucret.Clear();
            msodeme.Clear();
            mhskayit.Checked = false;
            sectigimguntxt.Clear();
            sectigimgun.Checked = false;
            herayinsongunu.Checked = false;
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
            Microsoft.Office.Interop.Excel.Range ran;
            ran = shee.get_Range("A1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran = shee.get_Range("B1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Kira Ücreti");
            ran = shee.get_Range("C1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Stopaj");
            ran = shee.get_Range("D1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Başlangıç Tarihi");
            ran = shee.get_Range("E1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Bitiş Tarihi");
            ran = shee.get_Range("A3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Adı Soyadı");
            ran = shee.get_Range("B3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "TC Kimlik");
            ran = shee.get_Range("C3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Mesleği");
            ran = shee.get_Range("D3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Adres");
            ran = shee.get_Range("E3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Brüt Hs.Kodu");
            ran = shee.get_Range("F3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Stpj.Hs.Kodu");
            ran = shee.get_Range("G3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Nt.Ücrt.Hs.Kodu");
            ran = shee.get_Range("A5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Mht.Ödm.Kodu");
            ran = shee.get_Range("A2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, aciklama.Text);
            ran = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, kiraucret.Text);
            ran = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, stopaj.Text);
            ran = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, bastarihi.Text);
            ran = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, bittarihi.Text);
            ran = shee.get_Range("A4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, sadi.Text);
            ran = shee.get_Range("B4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, skimlik.Text);
            ran = shee.get_Range("C4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, smeslegi.Text);
            ran = shee.get_Range("D4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, sadres.Text);
            ran = shee.get_Range("E4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, mbrut.Text);
            ran = shee.get_Range("F4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, mstopaj.Text);
            ran = shee.get_Range("G4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, msucret.Text);
            ran = shee.get_Range("A6", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, msodeme.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bastarihi.Text = odemetarihi.Text;
            odemetarihi.Enabled = false;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbortak.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO kiratanimlariaylikodemebilgileri(OdemeTarihi,BrutUcreti,StopajTutari,Aciklama,NetUcret,EntYapildi)VALUES('" + odemetarihi.Text + "','" + kiraucret.Text + " TL" + "','" + stopaj.Text + "','" + aciklama.Text + "','" + kiraucret.Text + " TL" + "','"+"Hayır"+"')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();

                listele();



                MessageBox.Show("Aylık ödeme bilgileri oluşturuldu ve aktarıldı!", "Kayıt İşlemi");



            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }
        public void listele()
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbortak.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            dt.Clear();

            SqlDataAdapter adpt = new SqlDataAdapter("Select*from kiratanimlariaylikodemebilgileri", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kira tanımı kaydı yapılamamaktadır.","Kira Tanımları");
        }

        private void ödemeBilgileriniOtoOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kira tanımı kaydı yapılamamaktadır.", "Kira Tanımları");
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

        private void herayinsongunu_CheckedChanged(object sender, EventArgs e)
        {
            if (sectigimgun.Checked)
            {
                sectigimguntxt.Enabled = true;
            }
            else if (herayinsongunu.Checked)
            {
                sectigimguntxt.Enabled = false;
            }
        }

        private void sectigimgun_CheckedChanged(object sender, EventArgs e)
        {
            if (sectigimgun.Checked)
            {
                sectigimguntxt.Enabled = true;
            }
            else if (herayinsongunu.Checked)
            {
                sectigimguntxt.Enabled = false;
            }
        }
    }
}
