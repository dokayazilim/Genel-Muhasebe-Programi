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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
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
            ustbutce.Clear();
            butcekodu.Clear();
            butcetanimi.Clear();
            durumu.SelectedIndex = -1;
            grubu.Clear();
            etkisi.SelectedIndex = -1;
            hedefbutce.Clear();
            plantipi.SelectedIndex = -1;
            aciklama.Clear();
            hesapkodu.Clear();
            hesapadi.Clear();
            bakiyetipi.SelectedIndex = -1;
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ustbutce.Clear();
            butcekodu.Clear();
            butcetanimi.Clear();
            durumu.SelectedIndex = -1;
            grubu.Clear();
            etkisi.SelectedIndex = -1;
            hedefbutce.Clear();
            plantipi.SelectedIndex = -1;
            aciklama.Clear();
            hesapkodu.Clear();
            hesapadi.Clear();
            bakiyetipi.SelectedIndex = -1;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet35.gelirbutcesi' table. You can move, or remove it, as needed.
            this.gelirbutcesiTableAdapter.Fill(this.mhsbdataDataSet35.gelirbutcesi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO gelirbutcesi(UstButce,ButceKodu,ButceTanimi,Durumu,Grubu,Etkisi,HedefButce,PlanlamaTipi,Aciklama,HesapKodu,HesapAdi,BakiyeTipi,BaslamaTarihi,BitisTarihi)VALUES('" + ustbutce.Text + "','" + butcekodu.Text + "','" + butcetanimi.Text + "','" + durumu.Text + "','" + grubu.Text + "','" + etkisi.Text + "','" + hedefbutce.Text + "','" + plantipi.Text + "','" + aciklama.Text + "','" + hesapkodu.Text + "','" + hesapadi.Text + "','" + bakiyetipi.Text + "','" + baslamatarihi.Text + "','" + bitistarihi.Text + "')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();

                listele();

                

                MessageBox.Show("Gelir bütçesi kaydedildi!", "Kayıt İşlemi");

               

            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            arama.Clear();   // arama textbox' ı...
            rdhesapkodu.Checked = false;  //Arama tab' ı hesap kodu radio button..
            rdhesapadi.Checked = false;   //Arama tab' ı hesap adı radio button..
            rddurumu.Checked = false;     //Arama tab' ı durumu radio button..
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rdhesapkodu.Checked)
            {

                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "HesapKodu like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else { }
            if (rdhesapadi.Checked)
            {

                BindingSource src = new BindingSource();
                src.DataSource = dataGridView1.DataSource;

                src.Filter = "HesapAdi like '%" + arama.Text + "%'";
                dataGridView1.DataSource = src;
            }
            else
            {

            }
            if (rddurumu.Checked)
            {

                BindingSource src = new BindingSource();
                src.DataSource = dataGridView1.DataSource;

                src.Filter = "Durumu like '%" + arama.Text + "%'";
                dataGridView1.DataSource = src;
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form98 a = new Form98();
            a.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO gelirbutcesi(UstButce,ButceKodu,ButceTanimi,Durumu,Grubu,Etkisi,HedefButce,PlanlamaTipi,Aciklama,HesapKodu,HesapAdi,BakiyeTipi,BaslamaTarihi,BitisTarihi)VALUES('" + ustbutce.Text + "','" + butcekodu.Text + "','" + butcetanimi.Text + "','" + durumu.Text + "','" + grubu.Text + "','" + etkisi.Text + "','" + hedefbutce.Text + "','" + plantipi.Text + "','" + aciklama.Text + "','" + hesapkodu.Text + "','" + hesapadi.Text + "','" + bakiyetipi.Text + "','" + baslamatarihi.Text + "','" + bitistarihi.Text + "')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();



                MessageBox.Show("Gelir bütçesi kaydedildi!", "Kayıt İşlemi");



            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }

        private void genelMuhasebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void listele()
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            dt.Clear();

            SqlDataAdapter adpt = new SqlDataAdapter("Select*from gelirbutcesi", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
