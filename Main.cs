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

            // enum Ÿ�Կ� ���� �����ϴ� ���
            myCity = City.Seoul;

            // enum�� int�� ��ȯ(Casting)�ϴ� ���.
            // (int)�� �տ� ����.
            int cityValue = (int)myCity;

            if (myCity == City.Seoul) // enum ���� ���ϴ� ���
            {
                Console.WriteLine("Welcome to Seoul");
            }

            // OR �����ڷ� ���� �÷��� �Ҵ� 1 | 100
            Border b = Border.Top | Border.Bottom; // 101

            // & �����ڷ� �÷��� üũ
            if ((b & Border.Top) != 0) //101 & 1 == 1
            {
                //HasFlag()�̿� �÷��� üũ
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" ���--> ToString
                    Console.WriteLine(b.ToString());
                }
            }
            */

            /*
            // ���ڿ�(string) ����
            string s1 = "C#";
            string s2 = "Programming";

            // ����(char) ����
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