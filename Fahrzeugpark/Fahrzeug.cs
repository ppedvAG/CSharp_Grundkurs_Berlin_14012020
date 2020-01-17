using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{

    public enum DeutscheAutoHersteller { Mercedes, BMW, VW, Audi}

    public class Fahrzeug
    {
        private int baujahr;
        private string marke;
        private double aktGeschwindigkeit;
        private double maxGeschwindigkeit;

        //private DeutscheAutoHersteller deutscheAutoHersteller;
        public bool MotorLaeuft { get; set; }


        //Auto Property
        public string Farbe { get; set; }


        /// <summary>
        /// Property für Baujahr
        /// </summary>
        public int Baujahr
        {
            get
            {
                return baujahr;
            }

            set
            {
                if (value >= 0)
                {
                    baujahr = value;
                }
                else
                {
                    // Fehler soll eskaliert werden.
                }
            }
        }

        public double AktGeschwindigkeit
        {
            get
            {
                return this.aktGeschwindigkeit;
            }

            set
            {
                //Aktuelle GEschwindikeit darf nicht unter 0 kmh fallen
                if (value < 0)
                {
                    this.aktGeschwindigkeit = 0;
                } //aktuelle Geschwindikeit darf nicht der maximal Geschwindigkeit
                else if (maxGeschwindigkeit < value)
                {
                    aktGeschwindigkeit = maxGeschwindigkeit;
                }
                else
                    aktGeschwindigkeit = value;
            }
        }

        public double MaxGeschwindigkeit
        {
            get
            {
                return this.maxGeschwindigkeit;
            }

            set
            {
                if (value >= 0)
                    maxGeschwindigkeit = value;
            }
        }

        public string Marke { get => marke; set => marke = value; }


        public Fahrzeug()
        {
            AnzahlErstellterFahrzeuge++;
        }

        public Fahrzeug(string marke, int baujahr, double maxGeschwindigkeit)
        {
            Marke = marke;
            Baujahr = baujahr;
            MaxGeschwindigkeit = maxGeschwindigkeit;
            AktGeschwindigkeit = 0;
            MotorLaeuft = false;

            AnzahlErstellterFahrzeuge++;
        }


        #region Anti-Beispiel für das befüllen und zugrefen einer Variable
        public void SetBaujahr(int bjahr)
        {
            baujahr = bjahr;
        } 

        public int GetBaujahr()
        {
            return baujahr;
        }
        #endregion



        private void StarteMotor()
        {
            this.MotorLaeuft = true;
        }

        private void StoppeMotor()
        {
            this.MotorLaeuft = false;
            this.aktGeschwindigkeit = 0;
        }

        public void Beschleunige(int geschwindigkeit)
        {
            if (geschwindigkeit > 0 && MotorLaeuft == false)
                StarteMotor();

            // ist das selbe wie MotorLaeuft == true
            if (MotorLaeuft)
            {
                if (this.AktGeschwindigkeit + geschwindigkeit > this.MaxGeschwindigkeit)
                {
                    AktGeschwindigkeit = this.MaxGeschwindigkeit;
                }
                else if (this.AktGeschwindigkeit + geschwindigkeit < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += geschwindigkeit;
            }
        }


        #region static Methoden

        public static double KmhToMph(double kmh)
        {
            return 0.6214 * kmh;
        }

        public static double MphToKmh(double mph)
        {
            return mph * 1.60934;
        }

        public static string ZeigeAnzahlFahrzeuge()
        {
            return $"Es wurden {AnzahlErstellterFahrzeuge} Fahrzeuge produziert.";
        }
        #endregion

        #region static Variablen
        public static int AnzahlErstellterFahrzeuge { get; private set; } = 0;
        #endregion


    }
}
