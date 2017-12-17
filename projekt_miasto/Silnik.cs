using projekt_miasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Silnik : IInformacje
{
    public double Pojemnosc { get; set; }
    public Pojazd pojazd { get; set; }

    public Silnik(int pojemnosc)
    {
        this.Pojemnosc = pojemnosc;

    }

    public static double ConvertLKmToMpg(double spalanie)
    {
        return (378.541 / spalanie) * 0.62137;
    }

    public static double ConvertMpgToLKM(double spalanie)
    {
        return 378.541 / (spalanie * 1.60934);
    }

    public void Dzialaj(double dystans, ZbiornikPaliwa zbiornikPaliwa)
    {
        double spalanieNa100 = this.Pojemnosc * 4;

        double copyIloscPaliwa = zbiornikPaliwa.IloscPaliwa;
        int x = 0;
            
        for (double i = 0; i <= dystans; i++)
        {
            copyIloscPaliwa -= spalanieNa100 * (i / 100);
            Console.WriteLine("Masz: " + copyIloscPaliwa.ToString("F1") + " paliwa");
            Console.WriteLine(" Kilometrow do celu: " + (dystans - i) + "km");
            copyIloscPaliwa = zbiornikPaliwa.IloscPaliwa;
            x++;
            if (x == 4)
            {
                x = 0;
            }
            Console.Clear();
        }
        zbiornikPaliwa.IloscPaliwa -= spalanieNa100 * (dystans / 100);
    }
}
