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
    public partial class Form109 : Form
    {
        public Form109()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Form109_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarisletmeDataSet4.hesapplani' table. You can move, or remove it, as needed.
            this.hesapplaniTableAdapter.Fill(this.muhasebeortakhesaplarisletmeDataSet4.hesapplani);
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarisletmeDataSet3.hesapozeti' table. You can move, or remove it, as needed.
            this.hesapozetiTableAdapter.Fill(this.muhasebeortakhesaplarisletmeDataSet3.hesapozeti);
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarisletmeDataSet2.gidersayfasi' table. You can move, or remove it, as needed.
            this.gidersayfasiTableAdapter.Fill(this.muhasebeortakhesaplarisletmeDataSet2.gidersayfasi);
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarisletmeDataSet1.gelirsayfasi' table. You can move, or remove it, as needed.
            this.gelirsayfasiTableAdapter.Fill(this.muhasebeortakhesaplarisletmeDataSet1.gelirsayfasi);

        }
    }
}
