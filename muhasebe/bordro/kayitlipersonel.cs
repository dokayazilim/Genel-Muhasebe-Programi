using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bordro
{
    public partial class kayitlipersonel : Form
    {
        public kayitlipersonel()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kayitlipersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bordroDataSet4.muhasebebilgi' table. You can move, or remove it, as needed.
            this.muhasebebilgiTableAdapter.Fill(this.bordroDataSet4.muhasebebilgi);
            // TODO: This line of code loads data into the 'bordroDataSet3.ogrenimadresbilgi' table. You can move, or remove it, as needed.
            this.ogrenimadresbilgiTableAdapter.Fill(this.bordroDataSet3.ogrenimadresbilgi);
            // TODO: This line of code loads data into the 'bordroDataSet2.kimlikbilgi' table. You can move, or remove it, as needed.
            this.kimlikbilgiTableAdapter.Fill(this.bordroDataSet2.kimlikbilgi);
            // TODO: This line of code loads data into the 'bordroDataSet1.sicilbilgi' table. You can move, or remove it, as needed.
            this.sicilbilgiTableAdapter.Fill(this.bordroDataSet1.sicilbilgi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ara.Clear();
            adird.Checked = false;
            siranord.Checked = false;
            pergruburd.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ara.Clear();
            adird.Checked = false;
            siranord.Checked = false;
            pergruburd.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ara.Clear();
            adird.Checked = false;
            siranord.Checked = false;
            pergruburd.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ara.Clear();
            adird.Checked = false;
            siranord.Checked = false;
            pergruburd.Checked = false;
        }
    }
}
