
using System;
using System.Collections.Generic;

//Mit Lambda oder Linq zu arbeiten wird dieser Namespace verwendet
using System.Linq;



namespace GenericListSamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }

        public Person(string name, int height, double weight)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample 1
            List<string> listeMitStrings = new List<string>();


            List<string> alteStringListe = new List<string>();
            alteStringListe.Add("123");
            alteStringListe.Add("456");
            alteStringListe.Add("789");

            
            //Langsame Variante eine Liste in eine Liste zu kopieren
            foreach (string currentString in alteStringListe)
            {
                listeMitStrings.Add(currentString);
            }

            //Schnellere Variante eine Liste in eine Liste zu kopieren
            listeMitStrings.AddRange(alteStringListe.ToArray());
            listeMitStrings.Add("Erstes Element");
            listeMitStrings.Add("Zweites Element");

            string[] stringArray = listeMitStrings.ToArray();

            //es 'kann' mit Index gearbeitet werden
            string item = listeMitStrings[0];

            foreach (string currentItem in listeMitStrings)
            {
                Console.WriteLine(currentItem);
            }
            #endregion

            #region Sample mit Personen + Lamba

            Person person1 = new Person("Gustav", 182, 89);
            Person person2 = new Person("Hannelore", 162, 55);
            Person person3 = new Person("Christian", 199, 80);
            Person person4 = new Person("Isolde", 188, 99);

            List<Person> personenListe = new List<Person>();

            personenListe.Add(person1);

            personenListe.Add(person2);

            personenListe.Add(person3);

            personenListe.Add(person4);


            foreach (Person currentPerson in personenListe)
            {
                Console.WriteLine($"Person: {currentPerson.Name} Größe: {currentPerson.Height} Gewicht {currentPerson.Weight}");
            }


            Console.WriteLine("Lambda Sample");

            Person[] resultList = personenListe.Where(x => x.Height < 180).ToArray();
            IEnumerable<Person> resultPersonenListe = personenListe.Where(x => x.Height > 180 && x.Weight > 80);

            foreach (Person currentPerson in resultList)
            {
                Console.WriteLine($"Person: {currentPerson.Name} Größe: {currentPerson.Height} Gewicht {currentPerson.Weight}");
            }



            Console.WriteLine("Selbes Ergebnis mit IEnumerable<T> ");
            foreach (Person currentPerson in resultPersonenListe)
            {
                Console.WriteLine($"Person: {currentPerson.Name} Größe: {currentPerson.Height} Gewicht {currentPerson.Weight}");
            }

            #endregion


            Stack<string> stack = new Stack<string>();
            stack.Push("Erstes Element");
            stack.Push("Zweites Element");
            stack.Push("Drittes Element");


            Dictionary<string, Person> dict = new Dictionary<string, Person>();



            Console.ReadKey();

        }
    }
}
