using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StreamWriter Beispiel
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("zahlen.txt");
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine(i);
                }
            }
            catch (FileNotFoundException ex)
            {
                //Schreibe ein Log
            }
            catch (Exception ex)
            {
                //Schreibe ein Log
            }
            finally
            {
                sw.Close();
            }
            #endregion

            #region StreamReader Beispiel

            StreamReader sr = null;

            try
            {
                sr = new StreamReader("zahlen.txt");

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                //Logging
            }
            catch(Exception ex)
            {
                //Logging
            }
            finally
            {
                sr.Close();
            }
            #endregion




        }
    }
}
