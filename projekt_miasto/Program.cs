﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Program
    {
        static void Main(string[] args)
        {

            Zwierzyniec.Instancja().DodajZwierzatko(new Labrador("labcio", 10));
            Zwierzyniec.Instancja().DodajZwierzatko(new Syjamski("kotel", 8));
            Zwierzyniec.Instancja().WyswietlInformacje();


            Osoba osoba1 = new Osoba();
            osoba1.UstawDane("Mateusz", "Biedak", Osoba.RodzajPlci.MEZCZYZNA, 25, new Adres("Test","Testowe","64-500",1,1), "biedakmateusz@gmail.com");
            osoba1.AdoptujZwierza(Zwierzyniec.Instancja().PobierzZwierzatko(0));
            osoba1.WyswietlInformacje();

            Zwierzyniec.Instancja().WyswietlInformacje();


            /*
            int end;
            //Console.WriteLine(silnik.ConvertLKmToMpg(7.2).ToString("F2"));
            //Console.WriteLine(silnik.ConvertMpgToLKM(50).ToString("F1"));

            Console.WriteLine("Podaj markę samochodu");
            String marka = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj Model: ");
            String model = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj Pojemność: ");
            double pojemnosc = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Podaj pojemność zbiornika paliwa");
            double pojemnoscZbiornika = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Podaj Ilość Paliwa: ");
            double iloscPaliwa = double.Parse(Console.ReadLine());
            Console.Clear();
            while (iloscPaliwa > pojemnoscZbiornika)
            {
                Console.WriteLine("Twój zbiornika nie pomieści tyle paliwa!");
                Console.WriteLine("");
                Console.WriteLine("Podaj Ilość Paliwa: ");
                iloscPaliwa = double.Parse(Console.ReadLine());
                Console.Clear();
            }

            Samochod samochod = new Samochod(marka, model, pojemnosc, iloscPaliwa, pojemnoscZbiornika);
            do
            {
                Console.WriteLine("Ile km chcesz przejechać?");
                double dystans1 = double.Parse(Console.ReadLine());
                samochod.Jedz(dystans1);
                Console.WriteLine("Wybierz Opcje: \n     (1) Jedz \n     (2) EXIT");
                end = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (end < 2);
            Console.Clear();


            Console.WriteLine("END");
            Console.ReadKey();
            */

        }
    }
}

