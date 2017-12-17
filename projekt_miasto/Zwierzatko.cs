using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
	abstract class Zwierzatko : IInformacje
	{
		public enum RodzajZwierzatka
		{
			DOMOWE = 0x0001,
			HODOWLANE = 0x0002,
			BRAK_DANYCH = 0x0000
		};

		public string Imie { get; private set; }
		public int Wiek { get; private set; }

		//tutaj powinny znaleźć sie odpowiednie konstruktory
		public Zwierzatko()
		{
			this.Imie = Toolbox.BRAK_DANYCH;
			this.Wiek = 0;
		}
		public Zwierzatko(string imie, int wiek) : this()
		{
			this.Imie = imie;
			this.Wiek = wiek;
		}

		public void UstawDane(string imie)
		{
			this.Imie = imie;
		}
		public void UstawDane(int wiek)
		{
			this.Wiek = wiek;
		}
		public void UstawDane(string imie, int wiek)
		{
			this.Imie = imie;
			this.Wiek = wiek;
		}
		/*
            metoda UstawDane powinna być przeciążona dla kilku wariantów argumentów
            dodatkowo powinna zawierać sprawdzenia poprawności wprowadzanych danych
        */

		/*
            metody abstrakcyjne nie posiadają w klasie , w której zostały zdefioniowane swoich deklaracji - jedynie nagłówek
            każda klasa, która będzie dziedziczyła z klasy bazowej musi posiadać implementacje tych metod
        */

		public abstract string GatunekZwierzatka();
		public abstract string RasaZwierzaka();
		public abstract void NiechZwierzCosPowie();

		public virtual void WyswietlInformacje()
		{
			Console.WriteLine("Mam na imię {0}. Mam lat: {1}. A moja rasa to {2}. A moj gatunek to: {3}", this.Imie, this.Wiek, this.RasaZwierzaka(), this.GatunekZwierzatka());
		}
		//ta metoda moze wyswietlic podstawowe informacje o zwierzaku
	}
}
