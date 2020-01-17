using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul003._1_Functions
{
    class Program
    {
        public static int Addiere(int a, int b)
        {
            //Variante 1:
            //int ergebnis = a + b;
            //return ergebnis;

            //Variante 2:
            return a + b;
        }

        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b + c + d;
        }

        public static double Addiere(double a, double b, double c)
        {
            return a + b;
        }

        public static int BildeSumme(params int [] summanden)
        {
            int summe = 0;

            foreach(int item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        

        static void Main(string[] args)
        {
            int result = Addiere(5, 7);

            //Aufruf der Addiere(int,int)-Funktion (optinale Parameter werden auf ihren Default-Wert gesetzt)
            int summe = Addiere(5, 10, 45);

            //Aufruf der gleichen Funktion unter verwendung der optionalen Parameter
            summe = Addiere(12, 45, 89 );


            BildeSumme(2, 3, 5);
            BildeSumme(new int[] { 3, 3, 4 });





            Console.WriteLine($"5 + 7 = {Addiere(5, 7)}");
            Console.ReadLine();

        }
    }
}
