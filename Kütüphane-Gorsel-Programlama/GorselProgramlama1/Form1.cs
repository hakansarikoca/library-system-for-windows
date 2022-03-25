using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama1
{
    public partial class Form1 : Form
    {
        public string ad = string.Empty, soyad = string.Empty, numara = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Uygulama uyg = new Uygulama();
            ad = textBox1.Text;
            soyad = textBox2.Text;
            numara = textBox3.Text;
            if (ad != null && soyad != null && numara != null)
            {
                 DialogResult OK = new DialogResult();
                 
                 OK = MessageBox.Show("Giriş Başarılı. Yönlendiriliyorsunuz ....", "HS Kütüphane Sistemi", MessageBoxButtons.OK);
                 if (OK == DialogResult.OK)
                 {
                  this.Hide();
                    uyg.label2.Text = ad + " " + soyad;
                    uyg.ShowDialog();
                    
                 }
                              
            }
            else
            {
                
                MessageBox.Show("Bilgilerinizi Doğru Giriniz !", "HS Kütüphane Sistemi", MessageBoxButtons.OK);
            }
            
        }
    }
}
