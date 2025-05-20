using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
   

        internal class BoxA
        {


            public int width;
            public int height;

            public int Area() //메서드
            {
                return this.width * this.height;
            }

            public BoxA(int width, int height) //생성자
            {
                this.width = width;
                this.height = height;

            }
        }
}
