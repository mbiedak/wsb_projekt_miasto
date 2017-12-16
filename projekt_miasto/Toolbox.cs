using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace projekt_miasto
{
    class Toolbox
    {
        public static string BRAK_DANYCH = "Brak danych";

        public static int inputInteger(string inputText, int min, int max)
        {
            int result = 0;

            while (true)
            {
                string liczba = Toolbox.inputString(inputText, false);

                result = int.Parse(liczba);

                if (!int.TryParse(liczba, out result) ||
                    (result < min || result > max))
                {
                    Console.WriteLine("Wprowadzono niepoprawna wartosc (Zakres {0} {1})", min, max);
                }
                else
                    break;
            }

            return result;
        }

        public static string inputString(string inputText, bool isEmpty)
        {
            string result = "";

            while (true)
            {
                Console.Write(inputText);
                result = Console.ReadLine();

                if (isEmpty)
                {
                    break;
                }
                else
                    if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Wartość nie może być pusta!");
                }
                else
                    break;
            }

            return result;
        }

        public static string kodPocztowy(bool isEmpty)
        {
            string result = "";
            Regex rgx = new Regex(@"^\d{2}-\d{3}$");

            while (true)
            {
                Console.Write("Podaj kod pocztowy w formacie ##-###: ");
                result = Console.ReadLine();

                if (string.IsNullOrEmpty(result) && isEmpty)
                {
                    break;
                }
                else if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Wartość nie może być pusta!");
                }
                else if (!rgx.IsMatch(result))
                {
                    Console.WriteLine("Niepoprawny format");
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        public static string email(bool isEmpty)
        {
            string result = "";
            Regex rgx = new Regex(@"^[0-9a-zA-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*(?<=[0-9a-z])@[0-9a-zA-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*[0-9a-zA-z]$");

            while (true)
            {
                Console.Write("Podaj adres e-mail: ");
                result = Console.ReadLine();

                if (string.IsNullOrEmpty(result) && isEmpty)
                {
                    break;
                }
                else if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Wartość nie może być pusta!");
                }
                else if (!rgx.IsMatch(result))
                {
                    Console.WriteLine("Niepoprawny format");
                }
                else
                {
                    break;
                }
            }
            return result;
        }
        public static string korektaEmail(string adresEmail)
        {
            string result = adresEmail;
            Regex rgx = new Regex(@"^[0-9a-zA-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*(?<=[0-9a-z])@[0-9a-zA-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*[0-9a-zA-z]$");

                if (string.IsNullOrEmpty(adresEmail))
                {
                result = Toolbox.BRAK_DANYCH;
                //Wartość nie może być pusta
                }
                else if (!rgx.IsMatch(adresEmail))
                {
                result = Toolbox.BRAK_DANYCH;
                //Niepoprawny format
                }
            return result;
        }
    }
}
