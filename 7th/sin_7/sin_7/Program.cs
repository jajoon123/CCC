using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------->과제 //만약 13이나 0같은걸 입력했을때 실행안되게
            //별 피라미드까지 시험범위
            //시험 연습문제 풀은것 중에서 그대로 나옴 //삼항연산자
            //손으로 써봐야됨 대문자 소문자 등등


            /*
            Console.WriteLine("월을 입력하세요");
            int input = int.Parse(Console.ReadLine());

            if (input > 12 || input < 1)
            {
                Console.WriteLine("잘못 입력하셨습니다.");
            }
            if (input >= 3 && input <= 5)
            {
                Console.WriteLine("봄");
            }
            if (input == 12)
            {
                Console.WriteLine("겨울");
            }
            else if (input == 6 || input <= 8)
            {
                Console.WriteLine("여름");
            }
            if (input >= 9 && input <= 11)
            {
                Console.WriteLine("가을");
            }
            else if (input == 12 || input > 0 && input < 3)
            {
                Console.WriteLine("겨울");
            }
            else
            {
                Console.WriteLine("숫자를 잘못 입력하셨어요");
            } */

            //별 피라미드

            for (int i = 0; i < 8; i++)
            {

                for (int j = 7; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}
