using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
	class ZbiornikPaliwa : IInformacje
	{
		public ZbiornikPaliwa(long maksymalnaIloscPaliwa)
		{
			this.MaksymalnaIloscPaliwa = maksymalnaIloscPaliwa;
		}

		public ZbiornikPaliwa(long maksymalnaIloscPaliwa, long iloscPaliwa)
		{
			this.MaksymalnaIloscPaliwa = maksymalnaIloscPaliwa;
			this.IloscPaliwa = iloscPaliwa;
		}

		public long MaksymalnaIloscPaliwa { get; private set; }
		public long IloscPaliwa { get; private set; }

		public void Dotankuj(long iloscPaliwa)
		{
			if ((this.IloscPaliwa + iloscPaliwa) > this.MaksymalnaIloscPaliwa)
			{
				Console.WriteLine("Chcesz nalac za duzo paliwa, maksymalnie mozesz dolac {0}", this.MaksymalnaIloscPaliwa - this.IloscPaliwa);
			}

		}
		public long Pobierz(long iloscPaliwa)
		{
			if (this.IloscPaliwa < iloscPaliwa)
			{
				Console.WriteLine("Chcesz pobrac za duzo paliwa, maksymalnie mozesz pobrac {0}", this.IloscPaliwa);
				return 0;
			}
			this.IloscPaliwa = -iloscPaliwa;
			return iloscPaliwa;
		}

		public void WyswietlInformacje()
		{
			throw new NotImplementedException();
		}
		//każda z powyżych metod musi być odpowiednio zabezpieczona, np. nie można dodatnkować wartości ujemnej
	}
}
