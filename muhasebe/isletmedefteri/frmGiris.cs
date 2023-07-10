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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.Text != "demo")
            {
                MessageBox.Show("Kullanıcı adı hatalı veya eksik girildi. Lütfen kontrol ediniz!","Uyarı");
            }
            else if (sifre.Text != "demo")
            {
                MessageBox.Show("Şifre hatalı veya eksik girildi. Lütfen kontrol ediniz!", "Uyarı");
            }
            else 
            {
            
                kayitlifirma a = new kayitlifirma();
                a.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
