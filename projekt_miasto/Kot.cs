using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Kot : Zwierzatko
    {
        public Kot(string imie, int wiek) : base(imie, wiek)
        {
            
        }
        public override string GatunekZwierzatka()
        {
            return "kot";
        }

        public override void NiechZwierzCosPowie()
        {
            Console.WriteLine("Miau miau");
        }

        public override string RasaZwierzaka()
        {
            throw new NotImplementedException();
        }

        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
        }
    }
}
