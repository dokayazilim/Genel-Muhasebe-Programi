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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arama.Clear();
            rdhesapkodu.Checked = false;
            rdhesapadi.Checked = false;
            rddurumu.Checked = false;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet7.giderbutcesi' table. You can move, or remove it, as needed.
            this.giderbutcesiTableAdapter.Fill(this.mhsbdataDataSet7.giderbutcesi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO giderbutcesi(UstButce,ButceKodu,ButceTanimi,Durumu,Grubu,Etkisi,HedefButce,PlanlamaTipi,Aciklama,HesapKodu,HesapAdi,BakiyeTipi,BaslamaTarihi,BitisTarihi)VALUES('" + ustbutce.Text + "','" + butcekodu.Text + "','" + butcetanimi.Text + "','" + durumu.Text + "','" + grubu.Text + "','" + etkisi.Text + "','" + hedefbutce.Text + "','" + plantipi.Text + "','" + aciklama.Text + "','" + hesapkodu.Text + "','" + hesapadi.Text + "','" + bakiyetipi.Text + "','" + baslamatarihi.Text + "','" + bitistarihi.Text + "')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();

                listele();



                MessageBox.Show("Gider bütçesi kaydedildi!", "Kayıt İşlemi");



            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form99 a = new Form99();
            a.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO giderbutcesi(UstButce,ButceKodu,ButceTanimi,Durumu,Grubu,Etkisi,HedefButce,PlanlamaTipi,Aciklama,HesapKodu,HesapAdi,BakiyeTipi,BaslamaTarihi,BitisTarihi)VALUES('" + ustbutce.Text + "','" + butcekodu.Text + "','" + butcetanimi.Text + "','" + durumu.Text + "','" + grubu.Text + "','" + etkisi.Text + "','" + hedefbutce.Text + "','" + plantipi.Text + "','" + aciklama.Text + "','" + hesapkodu.Text + "','" + hesapadi.Text + "','" + bakiyetipi.Text + "','" + baslamatarihi.Text + "','" + bitistarihi.Text + "')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();

                listele();



                MessageBox.Show("Gider bütçesi kaydedildi!", "Kayıt İşlemi");



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

        public void listele()
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            dt.Clear();

            SqlDataAdapter adpt = new SqlDataAdapter("Select*from giderbutcesi", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

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

    }
}
