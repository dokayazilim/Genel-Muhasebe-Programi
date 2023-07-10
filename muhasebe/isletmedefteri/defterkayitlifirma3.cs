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
    public partial class defterkayitlifirma3 : Form
    {
        public defterkayitlifirma3()
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

        private void defterkayitlifirma3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isletmedefteriortaklarDataSet5.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter3.Fill(this.isletmedefteriortaklarDataSet5.firmakayit);

        }
    }
}
