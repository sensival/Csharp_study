using System;
using System.Text;
using Ex_1_datatype;
using Ex_2_variable;
using Ex_3_array;
using Ex_4_String;
using Ex_6_operator;
using static Ex_5_enum.enum_class;
using static Ex_6_operator.operator_cls;

namespace Csharp_study
{
    class Program
    {
        public static void Main()
        {
            string str = null;
            operator_cls op_a = new operator_cls();
            op_a.doublequestion(str);
            

            /*
            City myCity;

            // enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 변환(Casting)하는 방법.
            // (int)를 앞에 지정.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) // enum 값을 비교하는 방법
            {
                Console.WriteLine("Welcome to Seoul");
            }

            // OR 연산자로 다중 플래그 할당 1 | 100
            Border b = Border.Top | Border.Bottom; // 101

            // & 연산자로 플래그 체크
            if ((b & Border.Top) != 0) //101 & 1 == 1
            {
                //HasFlag()이용 플래그 체크
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" 출력--> ToString
                    Console.WriteLine(b.ToString());
                }
            }
            */

            /*
            // 문자열(string) 변수
            string s1 = "C#";
            string s2 = "Programming";

            // 문자(char) 변수
            char c1 = 'A';
            char c2 = 'B';

            editString a = new editString();

            string s3 = a.combStr(s1, s2);
            a.sliceStr1_5(s3);

            Console.WriteLine();

            string s4 = "C# Studies";
            a.indexingStr(s4);

            Console.WriteLine();

            string str = "Hello";
            a.strToChar(str);

            Console.WriteLine();

            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            a.charToStr(charArray2);

            Console.WriteLine();

            char c3 = 'A';
            a.asciiplus3(c3);

            Console.WriteLine();

            StringBuilder sb = new StringBuilder();
            a.strBd(sb);
            */
        }
    }
}