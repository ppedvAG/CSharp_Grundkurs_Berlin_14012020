using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul002._3_enum_und_switch
{
   
    
    class Program
    {
        enum Anrede { Herr, Frau, Diverses };
       

        static void Main(string[] args)
        {
            //Index wäre von 0 bis 3
            int[] zahlen = { 34, 55, 63, 77 };

            string[] anredeStringArray = { "Herr", "Frau", "Other" };

            Anrede anrede = Anrede.Diverses;

            if (anrede == Anrede.Frau)
            {

            }else if (anrede == Anrede.Herr)
            {
                //Mach was
            }
            else if (anrede == Anrede.Diverses)
            {
            }
            else
            {

            }




            switch (anrede)
            {
                case Anrede.Frau:
                    //Hier keine 100 Zeilen
                    //Mach was
                    break;
                case Anrede.Herr:
                    //Mach was
                    break;
                default:
                    //Ist bestimmt Diverses
                    break; 
            }


            int index = (int)anrede;


        }
    }
}
