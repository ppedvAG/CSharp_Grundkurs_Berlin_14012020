using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002._1_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1 If-Stamtements

            // Variablen deklarieren und initialisieren
            int a = 25;
            int b = 30;

            // Ist Variable 'a' kleiner als Variable 'b'
            if (a < b)
            {
                Console.WriteLine($"Variable b ist größer als Variable a");
            } // Ist Variable 'a' gleich 30
            else if (a == 30)
            {
                Console.WriteLine($"Variable a hat den Wert 30");
            }
            else if (b == 30)
            {
                Console.WriteLine($"Variable b hat den Wert 30");
            }
            else
            {
                Console.WriteLine("Keine Bedienung wurde erfüllt");
            }

            //if - Kurzschreibweise -> a == b 
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            string name = "Otto";
            if (name == "Otto")
            {
                //wenn name Otto ist, wird dieser CodeBlock ausgeführt
            }

            char letter = 'e';
            if (letter == 'e')
            {

            }
            
            Console.WriteLine(ergebnis);
            #endregion

            #region Schleifen

            //int a = 25;
            //int b = 30;
            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife übersprungen
            while (a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
                

                if (a == 26)
                {
                    Console.WriteLine("Die Variable 'a' hat den Wert 29 erreicht und mit dem neu gelernten Schlüsselwort, wird die while-schleife verlassen");
                    break;
                }

                a++;
                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
            }

            Console.WriteLine("<--- while - Schleife --->");



            #region do while schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.

            //Setze die Variable auf den Wert 1 zurück
            a = 1;
            do
            {
                Console.WriteLine($"{a} ist kleiner als 100");
                a *= 2;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                
                continue;
                Console.WriteLine("Wird niemals ausgeführt");

            } while (a < 100);
            #endregion

            Console.Clear();
            #region for-.Schleife

            //for (int i =0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <100; i=i*2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 100; i > 0; i--)
            //{

            //}
            #endregion

            #endregion

            int[] zahlen = { 3, 6, 9, 12, 15, 18 };
            int anzahlDerElemente = zahlen.Length;

            // for schleife, zählerschleife. wenn auf listen zugegriffen werden, die einen Index unterstützen
            for (int counter = 0; counter == zahlen.Length; counter++)
            {
                Console.WriteLine(zahlen[counter]);
            }

            if (!zahlen.Contains(9))
            {
                Console.WriteLine("Der Wert 9 wurde gefunden");
            }

            //foreach Schleife
            foreach (int currentNumber in zahlen)
            {
                Console.WriteLine(currentNumber);
            }

            Console.WriteLine($"Anzahl der Elemente in meinem Array {zahlen.Length}");
            //index eines Array beginnt bei 0 
            Console.WriteLine(zahlen[0]);

            #region Mehrdimensionales Array - Advanced (bei keinen Anfänger)
            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }
            #endregion
        }
    }
}
