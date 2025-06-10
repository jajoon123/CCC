using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    //엘리게이트 선언 위치
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b) //인스턴스 메소드 
        {
            return a + b;
        }

        public static int Minus(int a, int b) //static 정적인 클래스 메소드
        {
            return a - b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //static 없으니까 여기에 접근할 수 있는 인스턴스 생성
            Calculator Calc = new Calculator(); //클래스 인스턴스
            MyDelegate Callback; //델리게이트(대리자) 인스턴스

            Callback = Calc.Plus;
            Console.WriteLine(Callback(5,3));
            Callback = new MyDelegate(Calc.Plus); //생성자
            Console.WriteLine(Callback(10,3));

            Callback = Calculator.Minus;
            Console.WriteLine(Callback(5, 3));
            Callback = new MyDelegate(Calculator.Minus); //생성자
            Console.WriteLine(Callback(10, 3));

        }
    }
}
