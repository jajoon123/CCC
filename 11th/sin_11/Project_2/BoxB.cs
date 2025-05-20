using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class BoxB
    {


        //캡슐화
        //private : 클래스 내부에서만 접근 가능

        private int width; //필드
        private int height;



        public int Area() //메서드
        {
            return this.width * this.height;
        }

        public BoxB(int width, int height) //생성자
        {
            this.width = width;
            this.height = height;
        }
    }
}
