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
    public partial class Form60 : Form
    {
        public Form60()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hesapkod.Checked)
            {

                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "HesapKodu like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else { }
            if (hesapad.Checked)
            {

                BindingSource src = new BindingSource();
                src.DataSource = dataGridView1.DataSource;

                src.Filter = "HesapAdi like '%" + arama.Text + "%'";
                dataGridView1.DataSource = src;
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama.Clear();
            hesapkod.Checked = false;
            hesapad.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form60_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeDataSet2.hesapkodlari' table. You can move, or remove it, as needed.
            this.hesapkodlariTableAdapter1.Fill(this.muhasebeDataSet2.hesapkodlari);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form5 frm2 = (Form5)Application.OpenForms["Form5"];
            frm2.hesapkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
            BindingSource sr = new BindingSource();
            sr.DataSource = dataGridView1.DataSource;

            sr.Filter = "HesapKodu like '%" + arama.Text + "%'";
            dataGridView1.DataSource = sr;
            
        }
        public void listele()
        {

            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\muhasebe.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            dt.Clear();

            SqlDataAdapter adpt = new SqlDataAdapter("Select*from hesapkodlari", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

    }
}
