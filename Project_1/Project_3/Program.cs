using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 : 같은 데이터 타입을 가진 데이터들의 집합(고정)

            int[] scores = new int[5]; //new -> 메모리를 할당해주는 메모리 할당 연산자, int형 5개가 들어가는 메모리를 생성
            scores[0] = 80;
            scores[1] = 75;
            scores[2] = 82;
            scores[3] = 90;
            scores[4] = 45;

            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            //배열을 초기화 하는 방법 네가지

            int[] scores_1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] scores_2 = new int[] { 10, 20, 30, 40, 50 };
            //int[] scores_3 = int[] {10,20,30,40,50};
            int[] scores_4 = { 10, 20, 30, 40, 50 };

            List<int> lists = new List<int> {};

        }
    }
}
