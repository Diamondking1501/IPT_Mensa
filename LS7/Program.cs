using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anzahl; do
            {
                Console.Write("How many books? 1 bis 5: ");

                anzahl = Convert.ToInt32(Console.ReadLine());
            }
            while (anzahl != 1 && anzahl != 2 && anzahl != 3 && anzahl != 4 && anzahl != 5);

            for (int i = 1; i <= anzahl; i++)
            {
                Console.WriteLine("book " + i + " registrated");
            }

            int offen = anzahl;

            while (offen > 0)
            {
                Console.WriteLine("still " + offen + " open"); offen--;
            }

            Console.WriteLine("Every book has been processed!");
        }
    }
}
