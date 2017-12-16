using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miasto
{
    class Labrador : Pies
    {
        public Labrador(string imie, int wiek) : base(imie, wiek)
        {

        }

        public override string RasaZwierzaka()
        {
            return "labrador";
        }

    }
}
