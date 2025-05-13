using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class MyMath //절대값 구하기
    {
        public static int Abs(int input)
        {
            //클래스 메서드 생성과 사용
            if(input >0)
            {
                return input;
            }
            else
            {
                return -input;
            }
        }
    }
}
