using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form37 : Form
    {
        public Form37()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form37_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdigerhesaplarDataSet2.kdvlistelerinisorgula' table. You can move, or remove it, as needed.
            this.kdvlistelerinisorgulaTableAdapter.Fill(this.mhsbdigerhesaplarDataSet2.kdvlistelerinisorgula);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KDV listesi sorgulanamadı.","KDV Listeleri");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KDV listesi sorgulanamadı.", "KDV Listeleri");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
