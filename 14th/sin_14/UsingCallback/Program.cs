using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCallback
{
    delegate int Compare(int a, int b);

    internal class Program //다음주 무명 델리게이터
    {

        static int AscendCompare(int a, int b)
        { if (a > b) { return 1; } else if (a == b) { return 0; } else { return -1; } }
        static int DescendCompare(int a, int b)
        { if (a < b) { return 1; } else if (a == b) { return 0; } else { return -1; } }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0; //바깥쪽 루프 인덱스 
            int j = 0; //안쪽 루프 인덱스
            int temp = 0; //두 값을 서로 바꿀 때 임시 저장소
            for (i = 0; i < DataSet.Length - 1; i++) //전체 Pass수
            { 
                for (j = 0; j < DataSet.Length - (i + 1); j++) //인정한
                { 
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    { 
                        temp = DataSet[j + 1]; DataSet[j + 1] = DataSet[j]; DataSet[j] = temp; 
                    } 
                } 
            }
        }



        static void Main(string[] args)
        {

            int[] array1 = { 4, 8, 5, 2, 9 };
            Console.WriteLine("Sorting ascending...");
            BubbleSort(array1, new Comparer(AscendCompare));

            for(int j=0; j<array1.Length; i++) 
            {
                Console.WriteLine($"array1[i]"); 
            }
            Console.WriteLine();
        }
    }
}
