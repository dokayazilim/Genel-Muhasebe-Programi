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
    public partial class irsaliyestok : Form
    {
        public irsaliyestok()
        {
            InitializeComponent();
        }

        private void irsaliyestok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet19.stokhareketfisleristokkayitlari' table. You can move, or remove it, as needed.
            this.stokhareketfisleristokkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet19.stokhareketfisleristokkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet18.stokhareketfislerikayitlar' table. You can move, or remove it, as needed.
            this.stokhareketfislerikayitlarTableAdapter.Fill(this.muhasebepaketlerDataSet18.stokhareketfislerikayitlar);

        }
    }
}
