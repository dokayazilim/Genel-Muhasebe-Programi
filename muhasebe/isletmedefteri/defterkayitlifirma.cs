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
    public partial class defterkayitlifirma : Form
    {
        public defterkayitlifirma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
        }

        private void defterkayitlifirma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isletmedefteriortaklarDataSet3.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter1.Fill(this.isletmedefteriortaklarDataSet3.firmakayit);

        }
    }
}
