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
    public partial class kalite : Form
    {
        public kalite()
        {
            InitializeComponent();
        }

        private void kalite_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet59.kalitekontrol' table. You can move, or remove it, as needed.
            this.kalitekontrolTableAdapter.Fill(this.muhasebepaketlerDataSet59.kalitekontrol);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet58.kaliteislemdetaylarisag' table. You can move, or remove it, as needed.
            this.kaliteislemdetaylarisagTableAdapter.Fill(this.muhasebepaketlerDataSet58.kaliteislemdetaylarisag);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet57.kaliteislemdetaylarisol' table. You can move, or remove it, as needed.
            this.kaliteislemdetaylarisolTableAdapter.Fill(this.muhasebepaketlerDataSet57.kaliteislemdetaylarisol);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet56.kalitebilgiler' table. You can move, or remove it, as needed.
            this.kalitebilgilerTableAdapter.Fill(this.muhasebepaketlerDataSet56.kalitebilgiler);

        }
    }
}
