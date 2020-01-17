using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;


namespace Fahrzeugpark_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug fahrzeug = new Fahrzeug();
            //Beispiel -> Param. Konstruktor
            Fahrzeug einFahrzeug = new Fahrzeug("BMW", 2019, 220);
            Fahrzeug weiteresFahrzeug = new Fahrzeug("Audi", 2020, 250);

            Console.WriteLine($"Marke: {einFahrzeug.Marke} \t mit Baujahr: {einFahrzeug.Baujahr} \t besitzt eine maximale Geschwindigkeit von: {einFahrzeug.MaxGeschwindigkeit}");
            Console.WriteLine($"Marke: {weiteresFahrzeug.Marke} \t mit Baujahr: {weiteresFahrzeug.Baujahr} \t besitzt eine maximale Geschwindigkeit von: {weiteresFahrzeug.MaxGeschwindigkeit}");


            einFahrzeug.Beschleunige(100);
            double mphGeschwindigkeit = Fahrzeug.KmhToMph(einFahrzeug.AktGeschwindigkeit);

            Console.WriteLine($"{einFahrzeug.Marke} fährt {einFahrzeug.AktGeschwindigkeit} kmh und umgerechnet {mphGeschwindigkeit} mph");
            weiteresFahrzeug.Beschleunige(120);

            Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());


            #region Vererbung

            PKW pkw = new PKW("BMW", 2019, 220, 4, 4);
            PKW pkw1 = new PKW("Ford", 2018, 180, 5, 4);

            pkw.Beschleunige(50);

            Console.WriteLine($"{pkw.Marke} \t {pkw.Baujahr} \t {pkw.MaxGeschwindigkeit} / {pkw.AktGeschwindigkeit} \t - Anzahl Türen: {pkw.AnzahlTueren} \t Anzahl Räder: {pkw.AnzahlRaeder}");

            Yacht yacht = new Yacht("Kühne", 1955, 12, Schiff.Schifftreibstoff.Diesel, 2, 2000000);


            Schiff schiff = new Schiff("BlubbBlubbWerft", 1954, 13, Schiff.Schifftreibstoff.Diesel, 2);
            #endregion

            Yacht yacht1 = new Yacht(schiff, 2000000, true);

            Console.ReadKey();


            Console.WriteLine("Garagen Beispiel - Polymorphie");
            
            Garage garage = new Garage();
            garage.Einparken(pkw);
            garage.Einparken(pkw1);
            garage.Einparken(schiff);
            garage.Einparken(yacht);

            foreach (Fahrzeug currentFahrzeug in garage.FahrzeugListe)
            {
                if (currentFahrzeug is ITuev)
                {

                    ITuev tuev= (ITuev)currentFahrzeug;
                    if (tuev.MussFahrzeugZumTüv())
                    {
                        Console.WriteLine("Muss zum Tuev");
                    }
                }
            }


            //List<PKW> resultList = garage.ZeigeAllePKWSInGarageAn();

            //foreach (PKW currentPKW in resultList)
            //{
            //    Console.WriteLine($"{currentPKW.Marke} \t {currentPKW.Baujahr} \t {currentPKW.MaxGeschwindigkeit} / {currentPKW.AktGeschwindigkeit} \t - Anzahl Türen: {currentPKW.AnzahlTueren} \t Anzahl Räder: {currentPKW.AnzahlRaeder}");

            //    if (currentPKW is ITuev)
            //    {
            //        Console.WriteLine("Hier kann man nach dem Tuevjahr prüfen)");

            //        if (currentPKW.MussFahrzeugZumTüv())
            //            Console.WriteLine("Muss zum Tüv");
            //    }
            // }

           
            //Dictionaries arbeitet mit der Klasse KeyValue
            Dictionary<string, PKW> autoRegister = new Dictionary<string, PKW>();
            Dictionary<Guid, PKW> register2 = new Dictionary<Guid, PKW>();

            register2.Add(Guid.NewGuid(), pkw);
            register2.Add(Guid.NewGuid(), pkw1);

            Guid id = Guid.NewGuid();

            autoRegister.Add(id.ToString(), pkw);
            autoRegister.Add(Guid.NewGuid().ToString(), pkw1);

            //Contain Key
            if (autoRegister.ContainsKey(id.ToString()))
            {
                PKW pkw2 = (PKW)autoRegister[id.ToString()];
            }
            
            if (autoRegister.ContainsValue(pkw))
            {

            }

            //KeyValuePair ist für das Lesen von Dictionaries 
            foreach (KeyValuePair<string, PKW> kvp in autoRegister)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }







            Console.ReadKey();
        }
    }
}
