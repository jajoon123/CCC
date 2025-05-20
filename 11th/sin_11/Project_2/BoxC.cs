using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class BoxC //앞 시간 작성 내용 실수로 단넷프레임워크 안써서 작성함, 잠자서 다 작성못함
    {

        //값을 안전하게 변경하기 위한 겟터와 셋터
        //변수를 바로 변경할 수는 없지만 변수를 변경하는
        //메서드를 만들고 메서드를 호출해서 변경
        private int width; //필드
        private int height;



        public int Area() //메서드
        {
            return this.width * this.height;
        }

        public BoxC(int width, int height) //생성자
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이를 자연수로 입력해주세요");
            }
        }

        //겟터 (Getter)

        public int GetWidth(int width)
        {
            return this.width;
        }
        public int GetHeight(int height)
        {
            return this.height;
        }

        //셋터 (Setter)

        public void SetWidth(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수로"); }
        }

        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수로"); }
        }
}
}
