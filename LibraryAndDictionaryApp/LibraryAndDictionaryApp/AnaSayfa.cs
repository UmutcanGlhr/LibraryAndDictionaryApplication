using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace LibraryAndDictionaryApp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register rgs = new register();
            rgs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            library lib = new library();
            lib.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&& textBox2.Text != "" && textBox3.Text != "" )
            {


                
            }
            else
            {
                MessageBox.Show("Eksik Alan Bırakmayınız");
            }
        }
    }
}
