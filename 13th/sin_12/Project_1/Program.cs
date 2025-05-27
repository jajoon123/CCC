using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //값 복사(Value Copy)와 참조 복사(Reference Copy)
            //값 복사와 참조 복사는 메모리와 동작 방식에서 중요한 
            //차이를 보이며, 프로그램의 동작과 성능에 큰 영향을 미친다.

            //1. 값 타입 복사

            Console.WriteLine(x); //10
            Console.WriteLine(Y); //20
            Console.WriteLine();

            //2. 참조 타입 복사
            //참조 타입 : class, array, string,delegate, object
            Person p1 = new Person();
            p1.Name = "Alice";

            Person p2 = p1;
            p2.Name = Bob;
            Console.WriteLine(p1.Name); //Bob
            Console.WriteLine(p2.Name); //Bob
        }
    }
}
