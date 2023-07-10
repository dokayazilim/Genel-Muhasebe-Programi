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
    public partial class yenifirma : Form
    {
        public yenifirma()
        {
            InitializeComponent();
        }

        private void yenifirma_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adi.Clear();
            soyadi.Clear();
            tckimlik.Clear();
            vergidairesi.Clear();
            telefon.Clear();
            ceptelefon.Clear();
            donem1.Clear();
            donem2.Clear();
            adres.Clear();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adi.Clear();
            soyadi.Clear();
            tckimlik.Clear();
            vergidairesi.Clear();
            telefon.Clear();
            ceptelefon.Clear();
            donem1.Clear();
            donem2.Clear();
            adres.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde sadece 'Demo' adlı şirketi kullanabilirsiniz!","Deneme Sürümü");
        }

        private void işletmeDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
