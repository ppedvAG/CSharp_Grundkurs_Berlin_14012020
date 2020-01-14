using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002._2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vorab Beispiel
            //Zufallsgenerator wird erstellt
            Random random = new Random();
            //Kleines Beispiel für Random
            //Gebe mir eine Zufallszahl aus zwischen 1 und 10
            int zufallszahl = random.Next(1, 10);
            //Ausgabe der Zufallszahl
            Console.WriteLine(zufallszahl);
            #endregion

            Random generator = new Random();
            int[] benutzerZahlen = new int[3];
            int[] zufallsZahlen = new int[3];
            int treffer = 0;


            //Würfel der Zahlen
            for (int i = 0; i < zufallsZahlen.Length; i++)
            {
                int temp;

                do
                {
                    temp = generator.Next(1, 11);
                } while (zufallsZahlen.Contains(temp));

                zufallsZahlen[i] = temp;
            }


            //Schleife zum Erfragen der Benutzerzahlen
            for (int i = 0; i < benutzerZahlen.Length; i++)
            {
                Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ");
                benutzerZahlen[i] = int.Parse(Console.ReadLine());
            }

            //Schleife zum Ausgeben der Gewinnzahlen UND zum Zählen der Treffer
            Console.Write("\nGewinnzahlen:");
            foreach (int zahl in zufallsZahlen)
            {
                Console.Write($" {zahl}");

                //Hochzählen der Treffervariablen bei Vorkommen in beiden Arrays
                if (benutzerZahlen.Contains(zahl))
                    treffer++;

            }
                

            //Ausgabe der Treffer:
            Console.WriteLine($"\n\nDu hast {treffer} richtige Zahl(en) erraten.");

            Console.ReadKey();
        }
    }
}
