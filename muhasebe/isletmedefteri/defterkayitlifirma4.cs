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
    public partial class defterkayitlifirma4 : Form
    {
        public defterkayitlifirma4()
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

        private void defterkayitlifirma4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isletmedefteriortaklarDataSet6.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter4.Fill(this.isletmedefteriortaklarDataSet6.firmakayit);

        }
    }
}
