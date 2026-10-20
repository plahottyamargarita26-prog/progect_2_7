using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_2_варіант_7_
{
    internal class TCircle
    {
        protected double r;

        public TCircle()
        {
            r = 1;
        }

        public TCircle(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Radius must be greater than zero");
            this.r = r;
        }

        public TCircle(TCircle c)
        {
            r = c.r;
        }

        public override string ToString()
        {
            return "Radius = " + r;
        }
        public virtual void Input()
        {
            Console.WriteLine("Enter the radius of the circle:");
            r = double.Parse(Console.ReadLine());
            if (r <= 0)
                throw new ArgumentException("Radius must be greater than zero");
        }
        public virtual void Output()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Area of ​​a circle = " + Area());
            Console.WriteLine("Circuit = " + Length());
        }

        public double Area()
        {
            return Math.PI * r * r;
        }

        public double SectorArea(double angle)
        {
            return Math.PI * r * r * angle / 360;
        }

        public double Length()
        {
            return 2 * Math.PI * r;
        }
        public override bool Equals(object obj)
        {
            if (obj is TCircle c)
                return r == c.r;

            return false;
        }

        public override int GetHashCode()
        {
            return r.GetHashCode();
        }

        public static TCircle operator +(TCircle a, TCircle b)
        {
            return new TCircle(a.r + b.r);
        }

        public static TCircle operator -(TCircle a, TCircle b)
        {
            return new TCircle(Math.Abs(a.r - b.r));
        }

        public static TCircle operator *(TCircle a, double k)
        {
            return new TCircle(a.r * k);
        }

        public static TCircle operator *(double k, TCircle a)
        {
            return new TCircle(a.r * k);
        }
    }
}
