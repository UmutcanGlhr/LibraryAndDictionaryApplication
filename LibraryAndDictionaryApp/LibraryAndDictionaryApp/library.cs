using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAndDictionaryApp
{
    public partial class library : Form
    {
        public library()
        {
            InitializeComponent();
            Conn.baglanti();
            gridac();
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&& textBox2.Text != "" && textBox3.Text != "" )
            {
                Conn.Command("insert into library (kitapadı,kitayazari,basımyili) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')");
                MessageBox.Show("Başarıyla Kayıt Edildi");
                gridac();
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Eksik Alan Bırakmayınız");
            }
           
        }
        public void gridac()
        {
            dataGridView1.DataSource = Conn.Table("select * from library");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Conn.Command("DELETE FROM library WHERE kitapadı = '"+textBox1.Text+"'And kitayazari = '"+textBox2.Text+"' And basımyili = '"+textBox3.Text+"'");
                MessageBox.Show("Başarıyla Kayıt Silindi");
                gridac();
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Eksik Alan Bırakmayınız");
            }
        }
    }
}
