using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //메서드 오버로딩
            //오버로딩은 하나의 메서드 이름에 여러 개의 구현을 올리는 것
            //이름과 매개변수를 가지고 프로토타입(코드 기본 모델) 결정

            //int
            Console.WriteLine(MaMath.Abs(10));

            //double
            Console.WriteLine(MaMath.Abs(10.234));

            //long
            Console.WriteLine(MaMath.Abs(214837382));

            Console.WriteLine();

            Console.WriteLine(MainApp.Plus(15, 30));
            Console.WriteLine(MainApp.Plus(15,30,45));
            Console.WriteLine(MainApp.Plus(10.5, 20.5));
            Console.WriteLine(MainApp.Plus(10, 20.5));
        }
    }
}
