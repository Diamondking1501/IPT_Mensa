using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Mensa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name des Artikels?");
            string Artikel = Console.ReadLine();

            Console.WriteLine("Preis des Artikels?");
            decimal Preis = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Wie viele?");
            int Menge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (Menge < 1)
            {
                Console.WriteLine("Fehler: Ungültige Menge!");
            }

            else
            {
                decimal zwischentotal = Preis * Menge;
                decimal rabatt = 0;

                if (Menge >= 5)
                {
                    rabatt = 0.20m;
                }
                else if (Menge >= 3)
                {
                    rabatt = 0.10m;
                }

                decimal rabattbetrag = zwischentotal * rabatt;
                decimal endtotal = zwischentotal - rabattbetrag;

                Console.WriteLine("***********************************************");
                Console.WriteLine("Artikel: " + Artikel);
                Console.WriteLine("Zwischentotal: " + zwischentotal.ToString("0.00") + " CHF");
                Console.WriteLine("Rabatt: " + (rabatt * 100).ToString("0") + " %");
                Console.WriteLine("Rabattbetrag: " + rabattbetrag.ToString("0.00") + " CHF");
                Console.WriteLine("Endtotal: " + endtotal.ToString("0.00") + " CHF");
                Console.WriteLine("***********************************************");
            }

            Console.ReadLine();
        }
    }
}