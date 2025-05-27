using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class MaMath
    {

        public static int Abs(int input)
        {
            if (input > 0)
            {
                return input;
            }
            else { return -input; }
        }

        public static double Abs(double input)
        {
            if (input > 0)
            {
                return input;
            }
            else
            {
                return -input;
            }
        }

        public static long Abs(long input)
        {
            if (input > 0)
            {
                return input;
            }
            else
            {
                return -input;
            }
        }
    }
}
