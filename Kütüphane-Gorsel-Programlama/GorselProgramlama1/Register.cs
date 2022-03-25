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
    public partial class Kayit : Form
    {
        public string Name, Surname, LibraryNumber;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 LogIn = new Form1();
            this.Hide();
            LogIn.Show();
        }

        public Kayit()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            Name = textBox1.Text;
            Surname = textBox2.Text;
            LibraryNumber = textBox3.Text;
            if (Name != null && Surname!= null && LibraryNumber != null)
            {
                DialogResult OK = new DialogResult();
                OK = MessageBox.Show("Kayıt Başarılı. Giriş Ekranına Yönlendiriliyorsunuz... ", "HS Kütüphane Sistemi", MessageBoxButtons.OK);
                
                if (OK == DialogResult.OK)
                {
                    this.Hide();
                    Form1 LogIn = new Form1();
                    LogIn.Show();
                }
            }
            else
            {
                
                MessageBox.Show("Bilgilerinizi Tekrar Kontrol Ediniz.");
            }
        }
    }
}
