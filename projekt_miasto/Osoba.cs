using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Osoba : IInformacje
    {
        public enum RodzajPlci 
        {
            MEZCZYZNA   = 0x0001,
            KOBIETA     = 0x0002,
            BRAK_DANYCH = 0x0000
        };

        private List<Zwierzatko> o_listaZwierzatek; //dodane

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }   //dodane
        public RodzajPlci Plec { get; private set; }
        public Adres Adres { get; private set; }
        public string AdresEmail { get; private set; }  //dodane

        /*
    tutaj powinny znaleźć sie odpowiednie konstruktory
    zakladamy, ze płeć jest niezmienna - zatem wydaje się, że jeden z pierwszych konstruktorów powinien jako argument przyjmować własnie płeć
*/
        public Osoba()
        {
            this.o_listaZwierzatek = new List<Zwierzatko>();
            this.Plec = RodzajPlci.BRAK_DANYCH;
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH);
            this.Adres = new Adres();
            this.Wiek = 0;
            this.AdresEmail = Toolbox.BRAK_DANYCH;
        }

        public Osoba(string imie, string nazwisko) : this()
        {
            this.UstawDane(imie, nazwisko);
        }

        public void UstawDane(string imie, string nazwisko)
        {
            if (!string.IsNullOrEmpty(imie))
                this.Imie = imie;

            if (!string.IsNullOrEmpty(nazwisko))
                this.Nazwisko = nazwisko;
        }
        public void UstawDane(string imie, string nazwisko, string adresEmail)
        {
            UstawDane(imie, nazwisko);
            this.AdresEmail = Toolbox.korektaEmail(adresEmail);
        }
        public void UstawDane(string imie, string nazwisko, RodzajPlci plec, int wiek, Adres adres, string adresEmail)
        {
            UstawDane(imie, nazwisko, adresEmail);
            this.Plec = plec;
            this.Wiek = wiek;
            this.Adres = adres;
        }
        public void UstawDane(string imie, string nazwisko, bool kontaktTylkoEmail)
        {
            UstawDane(imie, nazwisko);
            UstawDane(kontaktTylkoEmail);
        }

        public void UstawDane(bool kontaktTylkoEmail)
            { 
            this.AdresEmail = Toolbox.email(false);
            if (!kontaktTylkoEmail)
            {
                Adres.UstawDane();
            }
        }
        /*
		metoda UstawDane powinna być przeciążona dla kilku wariantów argumentów
		dodatkowo powinna zawierać sprawdzenia poprawności wprowadzanych danych
		sprawdzanei poprawności dla adresu email proszę zaimplementować w klasie toolbox
	*/

        public static Osoba StworzOsobe()
        {
            Osoba result = new Osoba();

            Console.WriteLine("=== wprowadz dane nowej osoby ===");

            result.UstawDane(Toolbox.inputString("Podaj imie:", true),
                            Toolbox.inputString("Podaj nazwisko:", false));

            result.Adres.UstawDane();

            return result;
        }

        public void AdoptujZwierza(Zwierzatko o_zwierzatko)
        {
            /*
            Zwierzyniec schronisko = Zwierzyniec.Instancja();
            schronisko.WyswietlInformacje();
            int indeks = Toolbox.inputInteger(string.Format("Podaj numer indeksu zwierzątka, które chcesz zaadoptować lub {0} aby zrezygnować: ", schronisko.IleZwierzat()), 0, schronisko.IleZwierzat());
            if (indeks == schronisko.IleZwierzat()) { Console.WriteLine("Zapraszamy ponownie! Zwierzęta czekają na twoje serce i ciepły dom."); }
            else
            {
                o_listaZwierzatek.Add(schronisko.PobierzZwierzatko(indeks));
                Console.WriteLine("Gratulacje! Zaadoptowałeś zwierzątko:");
                o_listaZwierzatek[o_listaZwierzatek.Count-1].WyswietlInformacje();
            }*/
            if (o_zwierzatko != null)
            {
                o_listaZwierzatek.Add(o_zwierzatko);
            }
        }
        //public void AdoptujZwierza(Zwierzatko o_zwierzatko);    

        public void WyswietlInformacje()
        {
            Console.WriteLine("Imie = {0} Nazwisko = {1}", this.Imie, this.Nazwisko);
            this.Adres.WyswietlInformacje();

            foreach (Zwierzatko zwierz in o_listaZwierzatek)
            {
                zwierz.WyswietlInformacje();
                zwierz.NiechZwierzCosPowie();
            }
        }

    }
}
