using System;
using Ex_1_datatype;
using Ex_2_variable;
using Ex_3_array;

namespace Csharp_study
{
    class Program
    {
        public static void Main()
        {
            Arr1 arr1 = new Arr1();
            arr1.prtArr1();
            Console.WriteLine();
            arr1.prtArr2();

            Arr2 arr2 = new Arr2();
            arr2.prtJagArr();

            int[] scores = { 80, 78, 60, 90, 100 };
            int sum = Arr3.CalculateSum(scores); // 배열 전달: 배열명 사용
            Console.WriteLine(sum);

        }
    }
}