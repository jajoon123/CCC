using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class MyClassC
    {
        //일반적인 속성 생성 방법
        public int myField; //필드(변수), backing field
        public int MyField //속성이름
        {
            get { return myField; }
            set { myField = value; } //value는 set 접근자의 암묵적 매개변수 
        }
    }


}
