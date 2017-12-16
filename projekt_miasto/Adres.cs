using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Adres : IInformacje
    { 
        public string Ulica { get; private set; }
        public string Miasto { get; private set; }
        public string KodPocztowy { get; private set; }
        public int NrDomu { get; private set; }
        public int NrMieszkania { get; private set; }

        public Adres ()
        {
            this.UstawDane(Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH, Toolbox.BRAK_DANYCH, 0, 0);
        }

        public Adres (string ulica, string miasto, string kodPocztowy, int nrDomu, int nrMieszkania) : this()
        {
            this.UstawDane(ulica, miasto, kodPocztowy, nrDomu, nrMieszkania);
        }

        public void UstawDane(string ulica, string miasto, string kodPocztowy, int nrDomu, int nrMieszkania)
        {
            this.Ulica = ulica;
            this.Miasto = miasto;
            this.KodPocztowy = kodPocztowy;
            this.NrDomu = nrDomu;
            this.NrMieszkania = nrMieszkania;
        }
        public void UstawDane()
        {
            //Funkcja prosi użytkownika o wprowadzenie danych
            this.Ulica = Toolbox.inputString("Podaj nazwę ulicy: ", false);
            this.NrDomu = Toolbox.inputInteger("Podaj numer domu: ",0, int.MaxValue);
            this.NrMieszkania = Toolbox.inputInteger("Podaj numer mieszkania: ", 0, int.MaxValue);
            this.KodPocztowy = Toolbox.kodPocztowy(false);
            this.Miasto = Toolbox.inputString("Podaj nazwę miasta zamieszkania: ", false);
        }
        /*
    metoda UstawDane powinna być przeciążona dla kilku wariantów argumentów
    dodatkowo powinna zawierać sprawdzenia poprawności wprowadzanych danych
    sprawdzanie poprawności dla kodu pocztowego proszę zaimplementować w klasie toolbox
*/
        public void WyswietlInformacje()
        {
            Console.WriteLine("{0} {1}/{2}\n{3} {4}", this.Ulica, this.NrDomu, this.NrMieszkania, this.KodPocztowy, this.Miasto);
        }
    }
}
