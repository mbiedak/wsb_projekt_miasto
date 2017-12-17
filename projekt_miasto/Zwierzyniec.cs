using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
	class Zwierzyniec : IInformacje
	{
		private static Zwierzyniec o_instancja = null;
		private List<Zwierzatko> o_listaZwierzatek;

		public Zwierzyniec()
		{
			o_listaZwierzatek = new List<Zwierzatko>();
		}
		public Zwierzyniec(Zwierzatko zwierzatko) : this()
		{
			o_listaZwierzatek.Add(zwierzatko);
		}

		public static Zwierzyniec Instancja()
		{
			if (o_instancja == null)
			{
				o_instancja = new Zwierzyniec();
			}
			return o_instancja;
		}
		public int IleZwierzat()
		{
			return o_listaZwierzatek.Count;
		}
		public void DodajZwierzatko(Zwierzatko o_zwierzatko)
		{
			if (o_zwierzatko != null)
			{
				o_listaZwierzatek.Add(o_zwierzatko);
				Console.WriteLine("Dziękujemy, zwierzyniec przyjął poniższe zwierzątko:");
				o_zwierzatko.WyswietlInformacje();
			}
		}
		//public Zwierzatko DodajZwierzatko(Zwierzatko o_zwierzatko) {}
		//metoda dodaje zwierzaka przekazanego jako argument 

		public Zwierzatko PobierzZwierzatko(int i_indeksZwierzatka)
		{
			if (i_indeksZwierzatka < o_listaZwierzatek.Count)
			{
				Zwierzatko wydane = o_listaZwierzatek[i_indeksZwierzatka];
				o_listaZwierzatek.RemoveAt(i_indeksZwierzatka);
				return wydane;
			}
			else
			{
				throw new IndexOutOfRangeException("W zwierzyńcu nie ma zwierzątka o podanym numerze");
			}
		}
		//public Zwierzatko PobierzZwierzatko(int i_indeksZwierzatka) {}
		//pobieramy zwierzaka z listy - jednoczesnie go z niej usuwajac - metoda powinna być "odporna" na błędy	

		public void WyswietlInformacje()
		{
			for (int i = 0; i < o_listaZwierzatek.Count; i++)
			{
				Console.Write("indeks {0}- ", i);
				o_listaZwierzatek[i].WyswietlInformacje();
			}
		}
		//ta metoda wyświetli listę dostępnych zwierzaków z informacją o indeksie, pod którym zwierzak występuje
	}
}
