using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
//        class Parent
//        {
//            public Parent()
//            {
//                Console.WriteLine("부모 생성자");
//;
//            }
//        }

//        class Child : Parent
//        {
//            public Child()
//            {
//                Console.WriteLine("자식 생성자");
//            }
//        }



        static void Main(string[] args)
        {
            //상속 했을 때 시본적인 생성자 호출 순서
            //Child child = new Child(); //자신 인스턴스 생성

            //파생 클래스의 생성자에게 기반 클래스의
            //생성자 매개변수를 넘겨주는 방법
            //base() : 기반 클래스의 생성자 

            //base 키워드를 사용한 생성자
            Child childA = new Child();
            Child childB = new Child();

            



        }
    }
}
