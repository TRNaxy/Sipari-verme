using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_verme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            f2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      

            if (textBox1.Text == "Umut" && textBox2.Text == "1903")
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adınızı Giriniz");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifrenizi Giriniz");
            }

            else 
            {
                MessageBox.Show("Kullanıcı Adınız Veya Şifreniz Yanlış");
            }
        }
    }
}
