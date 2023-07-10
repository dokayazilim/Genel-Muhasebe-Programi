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
    public partial class Form69 : Form
    {
        public Form69()
        {
            InitializeComponent();
        }

        private void Form69_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet44.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter.Fill(this.mhsbdataDataSet44.firmakayit);

            label3.Visible = false;

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True";
                con.Open();

                string komut = "INSERT INTO firmakayit(FirmaKodu,Soyadi,Adi,VergiNo,TCKimlikNo,Adres)VALUES('" + label3.Text + "','" + label3.Text + "','" + label3.Text + "','" + label3.Text + "','" + label3.Text + "','" + label3.Text + "')";

                SqlCommand komutsatir = new SqlCommand(komut, con);
                komutsatir.ExecuteNonQuery();

                listele();

                
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form62 a = new Form62();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Demo adlı şirketi seçtiniz!","Bilgilendirme");

            Form3 a = new Form3();
            a.Show();
            this.Hide();
        }
        public void listele()
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\mhsbdata.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            dt.Clear();

            SqlDataAdapter adpt = new SqlDataAdapter("Select*from firmakayit", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
