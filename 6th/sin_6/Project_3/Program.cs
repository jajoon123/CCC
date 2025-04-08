using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args) //사용자에게 현재 월을 입력받아 계절을 출력하는 프로그램 작성 -> 중간시험
        {
            Console.WriteLine("월을 입력하세요~");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("rkdmf");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨어요");
                    break;
            }

        }
    }
}
