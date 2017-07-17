using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dakikayı_Saate_Saniyeyi_Dakikaya_çeviren_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int dakika, saat;
            int sayı;
            sayı = Convert.ToInt32(textBox1.Text);


            saat = sayı / 60;
            label1.Text = saat.ToString();

            dakika = sayı % 60;
            label2.Text = dakika.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {        
                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
