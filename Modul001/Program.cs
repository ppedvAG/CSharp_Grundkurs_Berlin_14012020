using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul001
{
    class Program
    {
        static void Main(string[] args)
        {
            //UTF8 lässt €-Zeichen in einer Konsole anzeigen lassen
            Console.OutputEncoding = Encoding.UTF8;

            //Ausgabe von Hallo Welt
            Console.WriteLine("Hallo Welt");
            Console.ReadLine();


            //Hallo Variablen

            //Deklarieren einer Variable
            int alter;
            //Initialisierung einer Variable
            alter = 31;
            //Deklaration + Initialisierung
            string stadt = "Berlin";
            int summe = alter * 2;
            summe = summe * 2;

            Console.WriteLine(alter);
            Console.WriteLine(summe);
            Console.WriteLine(stadt);
            Console.ReadLine();

            //Referenz->https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types


            // long Variable
            // long ist ein Signed 64-bit integer mit einem Wertebereich: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long longVariable = 3147483648;
            Console.WriteLine($"Ausgabe einer long Variable: {longVariable}");

            //decimal für Geldbeträge
            decimal money = 3_555.645m;
            Console.WriteLine($"Geldausgabe:  { money} €");
            Console.ReadLine();

            //Ausgabe eines Buchstabens 
            char letterVariable = 'e';
            Console.WriteLine($"Buchstabe des Tages: {letterVariable}");
            Console.ReadLine();


            //Ausgabemöglichkeiten von Variablen 
            Console.WriteLine("So sollte man es nicht machen");
            Console.WriteLine("Ich bin " + alter + " Jahre und wohne in " + stadt);
            Console.ReadKey();

            Console.WriteLine("Ausgabe mit Index Platzhalter");
            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}", alter, stadt);
            Console.ReadKey();

            //Ab der Version C# 6
            Console.WriteLine($"Ich bin {alter} und wohne in {stadt}");
            Console.ReadKey();

            //CamelCase Beispiel
            string firstName = "Kevin";
            //ungarische Notation
            string strFirstName = "ungarische Notation.... wird in CSharp nicht verwendet";
            Console.ReadKey();


            Console.Write("Bitte geben Sie einen Namen ein: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Du heisst also {name}");
            Console.ReadKey();

            Console.Write("Bitte geben Sie ein Alter ein: ");
            string meinAlter = Console.ReadLine();
            //int myAge = Convert.ToInt32(meinAlter);
            int myAge;

            bool isValid = int.TryParse(meinAlter,out myAge);
            Console.Write(myAge);
            Console.WriteLine("");

            double myDoubleValue = 3.14;
            int convertedDoubleValue = Convert.ToInt32(myDoubleValue);
            Console.WriteLine(convertedDoubleValue);
            Console.ReadKey();

            //Nullable DataTypes 
            int? shoe = null;
            int normalValue;

            //Überprüfe, ob Variable shoe initialisiert wurde.
            if (shoe.HasValue)
            {
                normalValue = shoe.Value;
            }

            //decimal? myNullableDecimal = null;

            //DateTime? myBithdate = null;

            //string myText = string.Empty;
        }
    }
}
