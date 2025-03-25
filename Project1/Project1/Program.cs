using System; //using 사용하다, 자바 패키지 import느낌 , namespace -> 라이브러리 모듈
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program //class -> 설계도
    {

        //var global = 52; -> 여기서 사용하면 안됨

        static void Main(string[] args)
        {

            //Console.WriteLine((273.125).GetType());

            //var 키워드 : 변수의 자료형을 자동으로 지정
            //var 키워드 사용 조건
            //1. 지역변수 : 메서드  내부에 선언되어 있는 변수
            //2. 변수 선언과 동시에 초기화

            /*foreach (var item in collection)
            {

            } */

            var num1 = 100; //int 자료형
            var num2 = 100L; //long 자료형
            var num3 = 100.13; //double 자료형
            var num4 = 100.13F; //float 자료형

            //입력
            String  input1 = Console.ReadLine();

            Console.WriteLine(input1 + input1); //5252
            Console.WriteLine("input1 : " + input1); //문자열 연결 연산자
            Console.WriteLine("input1 : {0}", input1); //string 형식의 format
            Console.WriteLine($"input1 : {input1}"); //시험 //문자열 보기



             //자료형 변환
             //1.강제 자료형 변환
            var a1 = 10.5;
            var a2 = (int)10.5;
            var a3 = (double)10;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            //2. 문자열을 숫자로 변환

            /*string numstring = "52273;
              int intnum \ (int)numstring; */

            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(float.Parse("52.273"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());

            //3.기본 자료형을 문자열로 변환

            Console.WriteLine((52).ToString());
            Console.Write((52.273).ToString());

            Console.WriteLine((52).ToString().GetType());
            Console.Write((52.273).ToString().GetType());

            //문제 : inch 단위를 입력받아 cm 단위를 구하는 코드 작성
            //1inch = 2.54cm

            Console.WriteLine("inch 단위를 입력하세요: ");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + "inch는 " + (inch * 2.54)+ "cm입니다.");

            //숫자와 문자열 덧셈 : 숫자가 자동으로 문자열로 변환
            Console.WriteLine(52 + 273); //덧셈 연산자 
            Console.WriteLine("52" + 273); //문자열 연결 연산자
            Console.WriteLine("52" + "273"); //문자열 연결 연산자

            //소수점 제거

            double num = 52.273103;
            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));


        }
    }
}
