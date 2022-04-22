using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            sifre = txt_sifre.Text;
            kullaniciAdi = txt_kulad.Text;
            if(kullaniciAdi.ToLower()=="gamze" && sifre=="1")
            {
                MessageBox.Show("Başarılı Bir Şekilde Giriş Yaptınız. ", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "Bilgilendirme");
            }

        }
    }
}
