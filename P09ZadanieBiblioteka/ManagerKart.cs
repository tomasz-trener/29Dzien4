﻿using P10ZadanieBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieBiblioteka
{
    internal class ManagerKart
    {
        public List<Karta> WczytajKarty()
        {
            return new List<Karta>()
            {
                 new Karta()
                    {
                        Tytul = "O kurdlach dla opornych",
                        NrKarty= "1308/00",
                        Wydanie =1 ,
                        Autorzy = new List<Autor>()
                        {
                            new Autor()
                            {
                                Imie = "L",
                                Nazwisko = "Tarantoga",
                                DrugieImie = "A"
                            },
                            new Autor()
                            {
                                Imie = "I",
                                Nazwisko = "Tichy",
                            }
                        },
                        Sygnatury = new List<Sygnatura>()
                        {
                            new Sygnatura()
                            {
                                Aktywna = false,
                                Komenatrz = "(zgłoszona utrata 01.05.2000)",
                                NrSygnatury = 012371,
                                Cena = new Cena()
                                {
                                    WlasciwaCena = 17.5,
                                    Komentarz = "zakup z \r\n18.08 – \r\n20,00"
                                },
                                DataZakupu = new DateTime(2000,1,27),
                                Wypozyczenia = new List<Wypozyczenie>()
                                {
                                    new Wypozyczenie()
                                    {
                                        DataWypozyczenia = new DateTime(2000,2,22),
                                        PrzewidywanaDataZwrotu = new DateTime(2000,3,7),
                                        Uwagi = "06.03.2000 Zgoda na \r\nprzedłużenie",
                                        Przedluzenie = new Wypozyczenie()
                                        {
                                            PrzewidywanaDataZwrotu = new DateTime(2000,3,15),
                                            RzeczywistaDataZwrotu = new DateTime(2000,3,15)
                                        },
                                        Czytelnik = new Czytelnik()
                                        {
                                            NrKarty = "A1427"
                                        }
                                    }
                                }
                            }
                        }
                    }

            };
        }
    }
}
