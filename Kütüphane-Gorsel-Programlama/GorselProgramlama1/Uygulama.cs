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
    public partial class Uygulama : Form
    {
        
        int sayac = 0;
        
        public Uygulama()
        {          
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            sayac++;
            label4.Text = sayac.ToString();          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult okey = new DialogResult();
            okey = MessageBox.Show("Kitabı Kiralamak İstediğinize Emin Misiniz ?","HS Kütüphane Sistemi",MessageBoxButtons.YesNo);
            if (okey == DialogResult.Yes)
            {
                textBox1.Text = comboBox1.Text + " " + numericUpDown1.Value.ToString() + " Gün Kiralandı.";
                label8.Text = Convert.ToString(DateTime.Now.Day + numericUpDown1.Value) + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "' e Kadar Teslim Ediniz.";
            }
            else if (okey == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi","HS Kütüphane Sistemi",MessageBoxButtons.OK);
            }
            
        }
    }
}
