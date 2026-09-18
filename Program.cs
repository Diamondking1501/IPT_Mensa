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

            string artikelname;
            int menge;
            decimal einzelpreis;



            Console.WriteLine("Was Möchten Sie kaufen?");
            artikelname = Console.ReadLine();
            Console.WriteLine("Wie Viele?");
            menge = int.Parse(Console.ReadLine());
            Console.WriteLine("Was ist der Preis?");
            einzelpreis = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Die Gesamtkosten betragen: " + (menge * einzelpreis) + " CHF");
        }
    }
}