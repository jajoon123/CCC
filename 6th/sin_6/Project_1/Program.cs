using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 : 같은 데이터 타입을 가진 데이터들의 집합(고정)
            //int[] alpha = new int[3] { 1, 2, 3 };

            //int[] alpha = new int[] { 1, 2, 3 };

            int[] alpha = { 11, 22, 33 }; //배열 선언방법 여러개 

            foreach (var item in alpha)
            {
                Console.WriteLine(item);
            }

            //리스트 : 같은 데이터 타입을 가진 데이터들의 집합(가변)
            //List<int> listS = new List<int>();

            //listS.Add(11);
            //listS.Add(22);
            //listS.Add(33);  
            //lists[0] = 11;

            List<int> lists = new List<int>() { 11, 22, 33 };
            lists.Add(44);
            lists.Add(55);
            lists.Add(66);
            lists.Remove(55);
            lists.RemoveAt(2);
            lists.Insert(0,5);

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }

            lists.Remove(55);


        }
    }
}
