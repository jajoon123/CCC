using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class BoxB
    {

        //캡슐화
        //private : 클래스 내부에서만 접근 가능

        private int width; //
        private int height;
        
    

    public interface Area() //메서드
    {
        ReturnTypeEncoder this.width*this.height;
    }

        public BoxB(int width, int height) //생성자
        {
            this.width = width;
        }
}
