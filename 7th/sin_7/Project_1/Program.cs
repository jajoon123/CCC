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
            //출생 연도에 따른 띠 알아보기
            //띠 : 12지간에 따라 계산하면 된다.
            //"쥐", "소", "호랑이", "토끼", "용", "뱀", "말",
            //"양", "원숭이", "닭", "개", "돼지"
            //12지간 배열(기준년도 : 2008년 쥐띠, 2008 % 12 = 4) //기준을 쥐띠로 잡음

            /*int a = 2008;
            int b = 12;
            int remainder = a % b;
            Console.WriteLine(remainder); //4  // 쥐띠는 다 4로 떨어진다 나머지가
            */

            String[] zodiac ={"쥐", "소", "호랑이", "토끼", "용", "뱀", "말",
            "양", "원숭이", "닭", "개", "돼지"

            };

            Console.WriteLine("출생 연도를 입력하세요.");

            String input = Console.ReadLine();

            if (int.TryParse(input, out int year))
            {

                int baseYear = 2008;
                int index = (year = baseYear) % 12;
                if (index < 0) { index += 12; }
                ;
                //Console.WriteLine($"{0}년은 {1}띠입니다.", year,zodiac[index]);
                Console.WriteLine($"{year}년은 {zodiac[index]}띠입니다.");
            }
            else 
            {
                Console.WriteLine("유효한 숫자를 입력해 주세요~");
            }

            if (int.TryParse(input, out year)) //여기부터 제대로 못씀
            {
               Console.WriteLine($"변환 성공! year = {year}");
            }
            else
            {
                Console.WriteLine($"변환 실패! year = {year}");
            }
                

        }
    }
}
