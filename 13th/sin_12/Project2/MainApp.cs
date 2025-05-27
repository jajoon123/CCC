using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class MainApp
    {
        public static int Plus(int x, int y)
        {
            Console.WriteLine("Calling int Plus(int, int )");

            return x + y;
        }

        public static int Plus(int x, int y,int z)
        {
            Console.WriteLine("Calling int Plus(int, int , int)");

            return x + y+z;
        }

        public static double Plus(double x, double y)
        {
            Console.WriteLine("Calling double Plus(double, double )");

            return x + y;
        }

        public static double Plus(int x, double y)
        {
            Console.WriteLine("Calling double Plus(int, double )");

            return x + y;
        }
    }
}
