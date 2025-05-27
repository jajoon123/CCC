using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //상속
            //클래스는 다른 클래스로부터 유산을 물려받을 수 있음
            //필드, 메서드, 속성, 생성자
            //상속을 사용해 클래스 구현 부분의 코드 중복을 해결

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach(var item in Dogs)
            {
                item.Eat();
                item.Slepp();
                item.Bark(); 
            }
            Console.WriteLine();

            foreach (var item in Cats)
            {
                item.Eat();
                item.Slepp();
                item.Bark();
            }
            Console.WriteLine();

        }
    }
}
