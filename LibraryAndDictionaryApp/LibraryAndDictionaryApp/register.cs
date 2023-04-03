using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LibraryAndDictionaryApp
{
    public partial class register : Form
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        public register()
        {
            InitializeComponent();
            Conn.baglanti();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text!=""&& textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Conn.Command("insert into üyeler (ad,soyad,telno,kullaniciadi,sifre) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')");
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Formu eksiksiz doldurunuz");

            }

        }
    }
}
