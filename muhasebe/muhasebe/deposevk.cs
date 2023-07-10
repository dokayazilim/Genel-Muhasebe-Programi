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
    public partial class deposevk : Form
    {
        public deposevk()
        {
            InitializeComponent();
        }

        private void deposevk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet49.deposevkdepoislemleristoklar' table. You can move, or remove it, as needed.
            this.deposevkdepoislemleristoklarTableAdapter.Fill(this.muhasebepaketlerDataSet49.deposevkdepoislemleristoklar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet48.deposevkdepoislemlerikayitlar' table. You can move, or remove it, as needed.
            this.deposevkdepoislemlerikayitlarTableAdapter.Fill(this.muhasebepaketlerDataSet48.deposevkdepoislemlerikayitlar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet47.deposevkisemirleri' table. You can move, or remove it, as needed.
            this.deposevkisemirleriTableAdapter.Fill(this.muhasebepaketlerDataSet47.deposevkisemirleri);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet46.deposevkstokkayitlariislemkayitlari' table. You can move, or remove it, as needed.
            this.deposevkstokkayitlariislemkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet46.deposevkstokkayitlariislemkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet45.deposevkstokkayitlaristoklar' table. You can move, or remove it, as needed.
            this.deposevkstokkayitlaristoklarTableAdapter.Fill(this.muhasebepaketlerDataSet45.deposevkstokkayitlaristoklar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet44.deposevkdepo' table. You can move, or remove it, as needed.
            this.deposevkdepoTableAdapter.Fill(this.muhasebepaketlerDataSet44.deposevkdepo);

        }
    }
}
