using P06ZadaniePogoda.Properties;
using P09Konstruktory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06ZadaniePogoda
{
    public partial class Form1 : Form
    {
        const string sciezkaMiasta = "C:\\dane\\miasta.txt";
        public Form1()
        {
            InitializeComponent();
            wczytajMiasta();
        }

        private void wczytajMiasta()
        {
            string[] miasta = File.ReadAllLines(sciezkaMiasta,Encoding.UTF8);

            cbMiasta.Items.Clear();
            //for (int i = 0; i < miasta.Length; i++)
            //    cbMiasta.Items.Add(miasta[i]);

            cbMiasta.Items.AddRange(miasta);
            
        }

        private void btnPodajTemeperature_Click(object sender, EventArgs e)
        {
            Jednostka wybranaJednostka = Jednostka.Celsjusz;
            if (rbFarenheit.Checked)
                wybranaJednostka = Jednostka.Farenheit;
            else if (rbKelvin.Checked)
                wybranaJednostka = Jednostka.Kelvin;

            string wybraneMiasto = cbMiasta.Text;
            ManagerPogody mp = new ManagerPogody(wybranaJednostka);
            double temp = mp.PodajTemperature(wybraneMiasto);

            lblRaport.Text = string.Format("Temperatura w mieście {0} wynosi {1} w jednostce {2}",
                wybraneMiasto, temp, wybranaJednostka);


            //ustawienie obrazka 
            ManagerPogody mpCejsjusz = new ManagerPogody(Jednostka.Celsjusz);
            double tempCejsusz = mpCejsjusz.PodajTemperature(wybraneMiasto);
            if (tempCejsusz < 0)
                pbObrazek.Image = Resources.snow;
            else if (tempCejsusz <11)
                pbObrazek.Image= Resources.rain;
            else 
                pbObrazek.Image= Resources.sun;
        }
    }
}
