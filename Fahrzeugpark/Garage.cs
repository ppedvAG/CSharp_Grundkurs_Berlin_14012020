using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class Garage
    {
        //Direkte Deklaration + Instanziierung 
        private List<Fahrzeug> fahrzeugListe; // = new List<Fahrzeug>();

        public Garage()
        {
            //Instanziierung via Konstruktor
            fahrzeugListe = new List<Fahrzeug>();
        }


        public List<Fahrzeug> FahrzeugListe
        {
            get
            {
                return fahrzeugListe;
            }
        }

        public void Einparken (Fahrzeug fahrzeug)
        {
            if (fahrzeugListe != null)
            {
                fahrzeugListe.Add(fahrzeug);
            }
        }

        public List<PKW> ZeigeAllePKWSInGarageAn()
        {
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/type-testing-and-cast
            List<PKW> pkwListe = new List<PKW>();

            foreach (Fahrzeug currentFahrzeug in fahrzeugListe)
            {
                if (currentFahrzeug is PKW)
                {
                    PKW pkw = (PKW)currentFahrzeug;
                    pkwListe.Add(pkw);
                }
            }
            //..... 

            return pkwListe;
        }

        public List<Schiff> ZeigeAlleSchiffInGarageAn()
        {
            //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/type-testing-and-cast
            List<Schiff> pkwListe = new List<Schiff>();

            //..... 

            return pkwListe;
        }
    }
}
