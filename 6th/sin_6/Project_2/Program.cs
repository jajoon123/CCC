using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c#에서 문자열 서식화에 사용할 수 있는 바법 두 가지
            //String 형식의 Format() 메서드
            //문자열 보간(Interpilationg);

            Console.WriteLine("Total : {0}", 456);
            Console.WriteLine("Total : {0, -10:D}", 456);
            Console.WriteLine("Totla : {10. 10:D}", 456);
            Console.WriteLine("Totla : {10. 10:x}", 255);
            Console.WriteLine("Totla : {0:N}", 123456789);
            Console.WriteLine("Totla : {0:N}", 123456789);
            Console.WriteLine("Totla : {0:F}", 123 ,545);


        }
    }
}
