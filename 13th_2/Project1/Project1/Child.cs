using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Child : Parent
    {
        public Child() : base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }
        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(string input): base(input)");
        }
    
    }
}
