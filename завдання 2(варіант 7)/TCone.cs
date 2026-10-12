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
            return base.ToString() + ", висота = " + h;
        }
        public new void Input()
        {
            base.Input();
            Console.WriteLine("Введіть висоту конуса:");
            h = double.Parse(Console.ReadLine());
        }

        // Виведення даних
        public new void Output()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Об'єм конуса = " + Volume());
        }

        public double Volume()
        {
            return Math.PI * r * r * h / 3;
        }
    }
}
