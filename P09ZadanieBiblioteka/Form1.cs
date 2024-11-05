using P10ZadanieBiblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09ZadanieBiblioteka
{
    public partial class Form1 : Form
    {
        List<Karta> karty;
        public Form1()
        {
            InitializeComponent();

            ManagerKart mz = new ManagerKart();
            karty= mz.WczytajKarty();

            UzuplenijKarte(karty[0]);
        }

        private void UzuplenijKarte(Karta karta)
        {
            txtNrKarty.Text = karta.NrKarty;
            txtTytul.Text = karta.Tytul;
            txtWydanie.Text = karta.Wydanie.ToString();

            foreach (var a in karta.Autorzy)
                txtAutorzy.Text += a.Nazwisko + " " + a.Imie + " " + a.DrugieImie + Environment.NewLine;

            dtpDataZakupu.Value = karta.Sygnatury[0].DataZakupu;

            lbSygnatury.DataSource = karta.Sygnatury;
            lbSygnatury.DisplayMember = "Podglad";
        }

        private void lbSygnatury_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sygnatura zaznaczona = lbSygnatury.SelectedItem as Sygnatura;

            txtSygnaturaSzczegoly.Text = zaznaczona.NrSygnatury.ToString();
            lbHistoriaWypozyczen.DataSource = zaznaczona.Wypozyczenia;
            lbHistoriaWypozyczen.DisplayMember = "Podglad";

        }
    }
}
