using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class BoxD
    {
        //일반적인 속성 생성 방법
        //get과 set 접근자를 사용하여 속성 선언

        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0) { width = value; }
                else { Console.WriteLine("자연수 입력"); }
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set 
            {
                if (value < 0) { height = value; }
                else { Console.WriteLine("자연수 입력"); }
            }
        }

        public int Area() //메서드
        {
            return this.width * this.height;
        }

        public BoxD(int width, int height) //생성자
        {
            this.width = width;
            this.height = height;
        }
    }
}
