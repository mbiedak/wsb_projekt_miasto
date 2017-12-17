using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
	class Pies : Zwierzatko
	{
		public Pies(string imie, int wiek) : base(imie, wiek)
		{

		}

		public override string GatunekZwierzatka()
		{
			return "pies";
		}

		public override void NiechZwierzCosPowie()
		{
			Console.WriteLine("Hau hau");
		}

		public override string RasaZwierzaka()
		{
			throw new NotImplementedException();
		}
	}
}
