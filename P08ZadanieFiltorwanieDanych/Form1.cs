using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08ZadanieFiltorwanieDanych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();

            //foreach (var z in zawodnicy)
            //    lbDane.Items.Add(z.Imie + " " + z.Nazwisko);

            lbDane.DataSource = zawodnicy; // wiązanie danych
            lbDane.DisplayMember = "ImieNazwisko";
        }

        private void btnTemperatuara_Click(object sender, EventArgs e)
        {
            // chcemy odczytac, który zawodnik jest akutalnie zaznaczony 
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            ManagerPogody mp = new ManagerPogody(Jednostka.Celsjusz);
            double temp = mp.PodajTemperature(zaznaczony.Kraj);

            lblRaport.Text = string.Format("W kraju {0}, skąd pochodzi zawodnik {1} temepratura wynosi {2}",
                zaznaczony.Kraj, zaznaczony.ImieNazwisko, temp);

            int rozmiar = this.Width;
            lblRaport.MaximumSize = new Size(170, rozmiar-45);
            lblRaport.AutoSize = true;
        
        }
    }
}
