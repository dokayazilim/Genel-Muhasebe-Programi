using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace isletmedefteri
{
    public partial class kayitlifirmayeni : Form
    {
        public kayitlifirmayeni()
        {
            InitializeComponent();
        }

        private void kayitlifirmayeni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isletmedefteriortaklarDataSet2.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter.Fill(this.isletmedefteriortaklarDataSet2.firmakayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
            this.Hide();
        }
    }
}
