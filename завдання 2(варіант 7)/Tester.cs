using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_2_варіант_7_
{
    internal class Tester
    {
        public void Test()
        {
            TCircle c1 = new TCircle(3);
            TCircle c2 = new TCircle(5);
            TCircle c3 = new TCircle(c1);

            c1.Input();
            c1.Output();

            Console.WriteLine("Area of ​​a sector: " + c1.SectorArea(90));
            Console.WriteLine("Is c1 greater than c2? " + c1.IsBigger(c2));
            Console.WriteLine("c1 + c2: " + (c1 + c2));
            Console.WriteLine("c1 - c2: " + (c1 - c2));
            Console.WriteLine("c1 * 2: " + (c1 * 2));
            Console.WriteLine("2 * c1: " + (2 * c1));
            Console.WriteLine("Copy of c1: " + c3);

            TCone cone = new TCone();
            cone.Input();
            cone.Output();
            TCone cone2 = new TCone(cone);
            Console.WriteLine("Copy of cone: " + cone2);
            TCone cone3 = new TCone(3, 5);
            cone3.Output();
        }
    }
}
