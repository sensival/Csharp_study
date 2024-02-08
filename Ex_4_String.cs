using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4_String
{
    internal class editString
        // C# 문자열은 Immutable 즉 한번 문자열이 설정되면, 다시 변경할 수 없다.
        // 한번 그 값이 설정되면 다시 변경할 수 없는 타입을 Immutable Type이라 부르고, 반대로 값을 계속 변경할 수 있는 것을 Mutable Type이라 부른다
        // 예를 들어, 문자열 변수 s 가 있을 때, s = "C#"; 이라고 한 후
        // 다시 s = "F#"; 이라고 실행하면, .NET 시스템은 새로운 string 객체를 생성하여
        // "F#"이라는 데이타로 초기화 한 후 이를 변수명 s 에 할당한다.
        // 즉, 변수 s 는 내부적으로는 전혀 다른 메모리를 갖는 객체를 가리키는 것이다.
    {
        

        // 문자열 결합
        public string combStr(string s1, string s2)
        {
            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);
            return s3;
        }

        // 부분문자열 발췌
        public void sliceStr1_5(string s3)
        {
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}", s3substring);
        }

        // 문자열을 배열인덱스로 한문자 엑세스
        public void indexingStr(string s) 
        {   
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, s[i]);
            }
        }


        // 문자열을 문자배열로 변환
        public void strToChar(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
        }

        // 문자배열을 문자열로 변환
        public void charToStr(char[] charArray2)
        {
            string s = new string(charArray2);
            Console.WriteLine(s);
        }

        // 문자 연산
        // char는 ASCII 코드
        public void asciiplus3(char c3)
        {   
            char c4 = (char)(c3 + 3);
            Console.WriteLine(c4);  // D 출력
        }

        //문자열을 다루는데 중요한 클래스 중의 하나는 System.Text.StringBuilder
        //클래스이다.String 클래스는 위에서 설명한 대로 Immutable이기 때문에, 문자열 갱신을 많이 하는 프로그램에는 적당하지 않다.반면 Mutable 타입인 StringBuilder 클래스는 문자열 갱신이 많은 곳에서 자주 사용되는데 이는 이 클래스가 별도 메모리를 생성, 소멸하지 않고 일정한 버퍼를 갖고 문자열 갱신을 효율적으로 처리하기 때문이다.
        //특히 루프 안에서 계속 문자열을 추가 변경하는 코드에서는 string 대신 StringBuilder를 사용해야 한다.
        public void strBd(StringBuilder sb)
        {
            for (int i = 1; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }
            string s = sb.ToString();

            Console.WriteLine(s);

        }

             
    }
}
