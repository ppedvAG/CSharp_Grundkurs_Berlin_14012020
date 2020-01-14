using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul001_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variante mit Convert.ToInt32
            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben Sie die zweite Zahl ein: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            int ergebnis = zahl1 + zahl2;
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");

            //Variante mit TryParse
            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            string zahl1Eingabe = Console.ReadLine();
            string zahl2Eingabe = Console.ReadLine();
            
            int number1;
            int number2;
            
            if (int.TryParse(zahl1Eingabe, out number1) && int.TryParse(zahl2Eingabe, out number2))
            {
                int result = number1 + number2;
                Console.WriteLine($"Ergebnis: {result}");
            }

            
            Console.ReadKey();
            

        }
    }
}
