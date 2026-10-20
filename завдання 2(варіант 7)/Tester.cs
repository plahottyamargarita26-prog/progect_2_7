using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_2_варіант_7_
{
    internal class TCone : TCircle
    {
        protected double h;

        public TCone() : base()
        {
            h = 1;
            if (h <= 0)
                throw new ArgumentException("height must be greater than zero");
        }

        public TCone(double r, double h) : base(r)
        {
            this.h = h;
        }

        public TCone(TCone c) : base(c)
        {
            h = c.h;
        }

        public override string ToString()
        {
            return base.ToString() + ", height = " + h;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter the height of the cone:");
            h = double.Parse(Console.ReadLine());
            if (h <= 0)
                throw new ArgumentException("height must be greater than zero");

        }


        public override void Output()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Volume of a cone = " + Volume());
        }

        public double Volume()
        {
            return Math.PI * r * r * h / 3;
        }
    }
}
