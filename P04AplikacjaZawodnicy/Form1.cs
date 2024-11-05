﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            //   lbDane.Items.Add("jeden");
            //   lbDane.Items.Add("dwa");

            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();

            lbDane.Items.Clear();
            foreach (var z in zawodnicy)
            {
                lbDane.Items.Add(z.Imie + " " + z.Nazwisko);
            }
        }
    }
}
