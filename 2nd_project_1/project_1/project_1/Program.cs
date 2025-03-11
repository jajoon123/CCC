using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(445);
            Console.WriteLine('a');

            Console.WriteLine("System");
            Console.WriteLine();

            Console.WriteLine("Hello");
            Console.WriteLine(10 + 20 + 30);
            Console.WriteLine("10 " + "20" + "30");

            /**/
            //복합 대입 연산자
            int input = 0;
            input += 52; //input = input +52;

            //증감 연산자
            int num = 10;
            num++; //11
            Console.WriteLine(num); //11
            num--; //10
            Console.WriteLine(num); //10
            Console.WriteLine(num++); //10 //이 원리 알아두기
            Console.WriteLine(--num);

            //자료형

            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273f;
            double _double = 52.273;
            char _char = '글';
            String _string = "문자열"; //클래스 
            Boolean _boolean = true;

            //System.String ( 클래스) , 이거 알아두기 

            Console.WriteLine();
            Console.WriteLine(_int.GetType()); //get -> 값을 추출하다,읽어오다 set -> 읽어온 데이터를 할당하다,**하다(이거 못들음) 

            Console.WriteLine("문자열".GetType());


        }
        
    }
}
