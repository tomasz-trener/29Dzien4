using P05PrzegladKontroler.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05PrzegladKontroler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          //  pictureBox1.Image = Resources.R;
         // pictureBox1.ImageLocation
           
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                timer1.Stop();
            else
                progressBar1.Value += 10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // webBrowser1.Navigate("http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt");
        //    webBrowser1.Navigate("www.wp.pl");

            timer1.Start();
        }
    }
}
