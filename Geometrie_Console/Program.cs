using Geometrie_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie_Console
{

    
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            Circle c = new Circle(r);
            Sphere s = new Sphere(r);
            Cylinder l = new Cylinder(r, h);

            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());


            //Geometrie_Library.AbstractSample.Shape shape = new Geometrie_Library.AbstractSample.Shape();

            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
