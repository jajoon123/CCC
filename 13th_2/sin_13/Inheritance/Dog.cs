using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Dog
    {
        public int Age { get; set; }
        public string Color{get;set;}

        public Dog() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠"); }
        public void Slepp() { Console.WriteLine("쿨쿨"); }
        public void Bark() { Console.WriteLine("왈왈"); }

    }
}
