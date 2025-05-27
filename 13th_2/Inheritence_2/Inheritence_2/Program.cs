using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //다형성
            //코드 중복을 해결할 수 있는 것
            //다형성은 하나의 클래스가 여러 형태로 변환될 수 있는 성질
            //자식 클래스가 부로 클래스로 위장하는 것
            //기반 클래스와 파생 클래스 사이의 형식 변환 is,as
            //다형성 시험문제
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog() };
            List<Cat> Cats = new List<Dog>() { new Cat(), new Cat() };

            foreach (var item in Dogs) {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meao();
            }

            List<Animal> Animals = new List<animals> ();
            {
                new Dog,new Cat(), new Dog(), new Cat(), new Cat(), new Cat(), new Cat(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            {
                
            }


        }
    }
}
