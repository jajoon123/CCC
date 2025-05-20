using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxA boxA = new BoxA(10, 10);
            boxA.width = -15;
            Console.WriteLine(boxA.Area());
            Console.WriteLine(boxA);

            BoxB boxB = new BoxB(20, 20);
            //boxB.width = -20;
            Console.WriteLine(boxB.Area());
            Console.WriteLine();

            BoxC boxC = new BoxC(30, 30);
            Console.WriteLine(boxC.Area());
            boxC.SetWidth(-35);
            boxC.SetHeight(35);
            Console.WriteLine(boxC.Area());
            Console.WriteLine(boxC.Area());

        }
    }
}
