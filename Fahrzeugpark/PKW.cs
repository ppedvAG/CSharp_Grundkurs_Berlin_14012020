using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class PKW : Fahrzeug, ITuev
    {
        public int AnzahlTueren { get; set; }
        public int AnzahlRaeder { get; set; }
        
        public PKW(string marke, int baujahr, double maxGeschwindigkeit, int anzahlTueren, int anzahlRaeder)
            :base(marke, baujahr, maxGeschwindigkeit)
        {
            this.AnzahlTueren = anzahlTueren;
            this.AnzahlRaeder = anzahlRaeder;
        }

        #region ITuev Implementierung
        public bool MussFahrzeugZumTüv()
        {
            if (this.Baujahr % 4 == 0)
            {
                return true;
            }

            return false;
        }

        private bool isTested;
        public bool IsTested 
        {   get
            {
                return isTested;
            }
            set
            {
                isTested = value;
            }
        }

        private string tuevName;
        public string TuevName 
        { 
            get
            {
                return tuevName;
            }
            set
            {
                tuevName = value;
            }
        }
        #endregion
    }
}
