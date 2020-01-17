using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie_Library
{

    /// <summary>
    /// Basisklasse 
    /// </summary>
    public class Shape
    {
        public const double PI = Math.PI;
        protected double x, y;

        public virtual string Name { get; set; }

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }

        public virtual string Description()
        {
            return $"Ich bin eine Form";
        }
    }

    public class Circle : Shape
    {
        private string name;
        public Circle(double r) : base(r, 0)
        {
            name = string.Empty;
        }

        public override double Area()
        {
            return PI * x * x;
        }

        public override string ToString()
        {
            return $"Ich bin ein Kreis";
        }

        public override string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
}
