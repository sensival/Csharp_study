using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ex_3_array
{
    internal class Arr1
    {
        // 1차 배열
        string[] players = new string[10];
        string[] Regions = { "서울", "경기", "부산" };
        
        public void prtArr1()
        {
            for(int i=0; i< Regions.Length; i++)
            {
                Console.Write(Regions[i]+" ");
            }
        }

        // 2차 배열 선언 및 초기화
        string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

        public void prtArr2()
        {
            for (int i = 0; i < Depts.GetLength(0); i++)
            {
                for (int j = 0; j < Depts.GetLength(1); j++)
                {
                    Console.Write(Depts[i, j] + " ");
                }
                Console.WriteLine(); // 행이 끝날 때마다 줄바꿈
            }
        }

        // 3차 배열 선언
        string[,,] Cubes;


    }

    internal class Arr2
    {
        //Jagged Array (가변 배열)
        //1차 배열 크기(3)는 명시해야
        int[][] A = new int[3][];
        public Arr2() //  C#에서는 변수의 초기화 및 할당 구문이 메서드, 생성자 또는 다른 코드 블록 내에서 이루어져야 함
        {
            //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;
        }
        public void prtJagArr()
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.Write(A[i][j] + " ");
                }
                Console.WriteLine();
            }
        }


    }

    internal class Arr3
    {
        // static은 인스턴스를 생성하지 않고도 해당 메소드나 변수 접근 가능
        public static int CalculateSum(int[] scoresArray) // 배열 받는 쪽
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }
            return sum;
        }

          

    }
}
