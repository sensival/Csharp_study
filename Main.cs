using System;
using System.Text;
using Ex_1_datatype;
using Ex_2_variable;
using Ex_3_array;
using Ex_4_String;

namespace Csharp_study
{
    class Program
    {
        public static void Main()
        {
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
        }
    }
}