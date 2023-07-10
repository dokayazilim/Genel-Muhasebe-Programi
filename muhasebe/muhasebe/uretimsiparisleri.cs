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
    public partial class uretimsiparisleri : Form
    {
        public uretimsiparisleri()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void uretimsiparisleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet1.uretimsiparisleriodemebilgileri' table. You can move, or remove it, as needed.
            this.uretimsiparisleriodemebilgileriTableAdapter.Fill(this.muhasebepaketlerDataSet1.uretimsiparisleriodemebilgileri);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet.uretimsiparislerisipariskaydi' table. You can move, or remove it, as needed.
            this.uretimsiparislerisipariskaydiTableAdapter.Fill(this.muhasebepaketlerDataSet.uretimsiparislerisipariskaydi);

        }
    }
}
