using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //클래스의 구성 멤머
            //클래스의 첫 번째 멤버 필드
            //메서드(함수)

            //-----------------------------------------------------------------------------

            Test test = new Test();
            Console.Write(test.Power(45));
            Console.Write(test.Power(85));

            //Console.WriteLine(Test.Power(10));

            MyMath myMath = new MyMath();
            //Console.WriteLine(myMath.Abs(-25)) //오류가 뜸
            Console.WriteLine(MyMath.Abs(-25)); //인스턴스는 트리기 때문에 메모리 공간이 없다.
            //인스턴스가 접근하는게 아니라 클래스 자체가 메소드의 접근하고 있다. //MyMath보면 static이 있다. 
        }
    }
}
