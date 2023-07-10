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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tahakkukayi.Text == "")
            {
                MessageBox.Show("Tahakkuk Ayı boş geçilemez.","Uyarı");
            }
            else if (odenecekhesapkodu.Text=="")
            {
                MessageBox.Show("Ödenecek Hesap Kodu boş geçilemez.", "Uyarı");
            }
            else if (devredenkdvhesapkodu.Text == "")
            {
                MessageBox.Show("Devreden Hesap Kodu boş geçilemez.", "Uyarı");
            }
            else
            {
                Form112 a = new Form112();
                a.Show();
                this.Hide();
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form88 a = new Form88();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form89 a = new Form89();
            a.Show();
        }
    }
}
