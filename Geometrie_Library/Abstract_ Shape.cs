using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie_Library.AbstractSample
{
    
    public abstract class Shape
    {
        public const double PI = Math.PI;

        public abstract double GetArea();
    }

    public class Square : Shape
    {
        int side;

        public Square(int n)
        {
            side = n;
        }

        // GetArea method is required to avoid a compile-time error.
        public override double GetArea()
        {
            return side* side;
        }

        static void Main()
        {
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }

    public class Circle : Shape
    {
        double x;

        public double X { get; set; }

        public Circle (double x)
        {
            this.X = x;
        }

        

        public override double GetArea()
        {
            return PI * X * X;
        }
    }
    // Output: Area of the square = 144
}
