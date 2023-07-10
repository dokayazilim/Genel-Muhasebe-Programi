using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class uretimreceteleri : Form
    {
        public uretimreceteleri()
        {
            InitializeComponent();
        }

        private void uretimreceteleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet8.receteuretimler' table. You can move, or remove it, as needed.
            this.receteuretimlerTableAdapter.Fill(this.muhasebepaketlerDataSet8.receteuretimler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet7.receteicerikler' table. You can move, or remove it, as needed.
            this.receteiceriklerTableAdapter.Fill(this.muhasebepaketlerDataSet7.receteicerikler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet6.recetekayitlari' table. You can move, or remove it, as needed.
            this.recetekayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet6.recetekayitlari);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
