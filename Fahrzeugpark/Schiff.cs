using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    
    public class Schiff : Fahrzeug
    {
        //Nested Enum
        public enum Schifftreibstoff { Diesel, Dampf, Wind, Muskelkraft}


        public Schifftreibstoff Treibstoff { get; set; }
        public double Tiefgang { get; set; }



        public Schiff (string marke, int baujahr, double maxGeschwindigkeit, Schifftreibstoff schifftreibstoff, double tiefgang)
            :base(marke, baujahr, maxGeschwindigkeit)
        {
            Tiefgang = tiefgang;
            Treibstoff = schifftreibstoff;
        }
    }


    public class Yacht : Schiff, ITuev
    {
        public int Wert { get; set; }
        public bool Pool { get; set; }

        private bool isTested;
       
        public string TuevName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsTested { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Yacht(string marke, int baujahr, double maxGeschwindigkeit, Schifftreibstoff schifftreibstoff, double tiefgang, int wert)
            :base(marke, baujahr, maxGeschwindigkeit, schifftreibstoff, tiefgang)
        {
            this.Wert = wert;
        }

        public Yacht(Schiff schiff, int wert, bool pool)
            :base(schiff.Marke, schiff.Baujahr, schiff.MaxGeschwindigkeit, schiff.Treibstoff, schiff.Tiefgang)
        {
            this.Wert = wert;
            this.Pool = pool;
        }


        /// <summary>
        /// Kopierkonstruktor 
        /// </summary>
        /// <param name="yacht"></param>
        public Yacht(Yacht yacht)
            :base(yacht.Marke, yacht.Baujahr, yacht.MaxGeschwindigkeit, yacht.Treibstoff, yacht.Tiefgang)
        {
            this.Pool = yacht.Pool;
            this.Wert = yacht.Wert;
        }

        public bool MussFahrzeugZumTüv()
        {
            if (this.Baujahr % 9 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
