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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.Text != "demo")
            {
                MessageBox.Show("Yanlış veya eksik kullanıcı adı girişi yaptınız! Lütfen tekrar kontrol ediniz!", "Sistem Uyarı");
            }
            else if (sifre.Text != "demo") 
            {
                MessageBox.Show("Yanlış veya eksik şifre girişi yaptınız! Lütfen tekrar kontrol ediniz!", "Sistem Uyarı");
            }

            else if (gk.Text != "demo") 
            {
                MessageBox.Show("Yanlış veya eksik güvenlik kodu girişi yaptınız! Lütfen tekrar kontrol ediniz!", "Sistem Uyarı");
            }
            else
            {

                
                MessageBox.Show("Güvenlik Sistemi aktif. Bu sistem sizleri zararlı virüslerden korumaya yarar. Programı kullanım esnasında bazı kasılmalar meydana gelebilir. Bu durum, sizden kaynaklanan bir sorun olmayabilir. Lütfen kullandığınız anti-virüs yazılımının açık olduğundan emin olunuz!","Güvenlik Sistemi");
                MessageBox.Show("Genel Muhasebe Smart' a hoşgeldiniz! Öncelikle programı nasıl kullanacağınızla ilgili ayarları yapılandırmanız gerekmektedir. Tüm ayarlamaları yaptıktan sonra programı kullanmağa başlayabilirsiniz.","Genel Muhasebe Smart");
                ayarlar a = new ayarlar();
                a.Show();
                this.Hide();

            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (sonuc == DialogResult.No)
            {
               
            }
            
        }
    }
}
