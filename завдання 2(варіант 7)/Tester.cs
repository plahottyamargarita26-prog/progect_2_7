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

            c1.Input();
            c1.Output();

            Console.WriteLine("Площа сектора: " + c1.SectorArea(90));
            Console.WriteLine("c1 більше за c2? " + c1.IsBigger(c2));
            Console.WriteLine("c1 + c2: " + (c1 + c2));
            Console.WriteLine("c1 - c2: " + (c1 - c2));
            Console.WriteLine("c1 * 2: " + (c1 * 2));
            Console.WriteLine("2 * c1: " + (2 * c1));

            TCone cone = new TCone();
            cone.Input();
            cone.Output();
        }
    }
}
