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
            //14번 문제

            /* Console.WriteLine("이름을 입력하세요 : ");
             String name = Console.ReadLine();
             Console.WriteLine("나이를 입력하세요 : ");
             int age = int.Parse(Console.ReadLine());
             Console.WriteLine("5년 후의 나이는 " + (age + 5) + "살 입니다.");
             Console.WriteLine("{0}님의 5년 후 나이는 {1}살 입니다.", name,age); //여기쪽 부분 시험 //String형식의 포멧으로 바꿔주세요 문자열연결연산자(+)


             Console.WriteLine($"{name}님의 5년 후 나이는 {age}살 입니다.", name, age);*/

            //15번은 패스 (알아서 풀어보기)

            //16번 문제 //코딩문제중 시험

            Console.WriteLine("원의 반지름 입력 : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("원의 둘레 : " + (2 * 3.14 * radius));
            Console.WriteLine("원의 둘레 :  {0}", (2 * 3.14 * radius));
            Console.WriteLine($"원의 둘레 :  {(2*3.14*radius)}");
            Console.WriteLine("원의 넓이: " + (3.14 * radius * radius));


            //5주차 c#수업

           //1번 ->   -2 < x && x <=3, 2번 -> 5<= && x<7 , 3번 -> x<=-20 || 20<=x
           //2번 -> 3번
           //3번 -> 1번
           //4번 -> 1번
           //5번 ->  //중간에 졸음
           
        }
    }
}
