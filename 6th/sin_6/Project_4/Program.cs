using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    internal class Program //일부러 몇 개 틀리게 작성 집적해보기
    {
        static void Main(string[] args)
        {
            Console.WriteLine("월을 입력하세요");
            int input = int.Parse(Console.ReadLine());

            if(input>=3 && input<=5)
            {
                Console.WriteLine("봄");
            }
            if (input >= 6 && input <= 8)
            {
                Console.WriteLine("여름");
            }
            if (input >= 9 && input <= 11)
            {
                Console.WriteLine("가을");
            }
            if (input >= 12 || input <= 2)
            {
                Console.WriteLine("겨울");
            }

            if(input>=3 && input<=5)
            {
                Console.WriteLine("봄");
            }
            if(input ==12)
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
            else if(input ==12 || input >0 && input < 3)
            {
                Console.WriteLine("겨울");
            }
            else
            {
                Console.WriteLine("숫자를 잘못 입력하셨어요");
            }
            /////-------------- 과제

            if(input == 12)
            {
                Console.WriteLine("겨울");
            }
            else if(input >=9)
            {
                Console.WriteLine("가을");
            }
            else if(input >= 6)
            {
                Console.WriteLine("여름");
            }
            else if (input >= 3)
            {
                Console.WriteLine("봄");

            }
            else if (input >= 1)
            {
                Console.WriteLine("겨울");
            }
            else
            {
                Console.WriteLine("잘못 입력하셨습니다.");
            }

            


        }
    }
}
