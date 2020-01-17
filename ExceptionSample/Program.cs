using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample
{

    public class MeineException : Exception
    {
        public MeineException()
            :base("Dies ist mein Fehler")
        {

        }
    }

    public class TestClass
    {
        public void CriticalMethod ()
        {
            //Wenn eine Über..........
            throw new MeineException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                TestClass testClass = new TestClass();
                testClass.CriticalMethod();
                //string eingabe = Console.ReadLine();
                //int a = int.Parse(eingabe);
            }
            catch (MeineException ex)
            {
                Console.WriteLine("Eigene Exception wurde ausgelöst und hier abgefange");
                Console.WriteLine($"StackTrace {ex.StackTrace}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Die Zahl ist zu groß/klein.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Du musst eine Zahl eingeben. \n {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unbekannter Fehler ist aufgetreten");
            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt");
            }


            //Mit dem THROW-Befehl können manuell Exceptions geworfen werden
            throw new MeineException();
        }
    }
}
