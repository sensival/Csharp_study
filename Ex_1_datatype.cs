using System;

namespace Ex_1_datatype{
   public class print_test
   {
        public void printMsg() //메세지 출력
        {
            Console.WriteLine("HelloWorld!");
            Console.WriteLine("어서오세요 C#으로!");
        }
        public void print_repetitive() //반복문 출력
        {
            for( int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

   } 
    public class data_types // 데이터 타입
    {
            // Bool
            bool b = true ; //or false, 디폴트 리터럴 타입

            // Numeric
            byte bt = 32; // 8비트 unsigned integer
            sbyte sbt = -32; //8비트 signed integer
            short sh = -32768;  // 16비트 signed integer
            ushort ush = 32768; //   16비트 unsigned integer
            int i = 2147483647;  //   32비트 signed integer, 디폴트 리터럴 타입
            uint ui = 2147483647; // U suffix,  32비트 unsigned integer
            long l = 1234L;      // L suffix,    64비트 signed integer
            ulong ul =1234;      // UL suffix,  64비트 unsigned integer
            float f = 123.45F;   // F suffix,    32비트 single precision 부동소수점 숫자
            double d1 = 123.45; //   64비트 double precision 부동소수점 숫자, 디폴트 리터럴 타입
            double d2 = 123.45D; // D suffix
            decimal d = 123.45M; // M suffix,    128비트 Decimal

            // Char/String
            char c = 'A'; // 16비트 유니코드 문자, 디폴트 리터럴 타입
            string s = "Hello"; //    유니코드 문자열, 디폴트 리터럴 타입

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            // object
            object ob; //   모든 타입의 기본 클래스로 모든 유형을 포함할 수 있음

            // 최대값, 최소값
            int i2 = int.MaxValue;
            public void printMax()
            {
                 System.Console.WriteLine(i2);
            }
            float f2 = float.MinValue;
            public void printMin()
            {
                 System.Console.WriteLine(f2);

            }
            
            // NULL을 가질 수 있는 타입 (Reference 타입, heap에 저장): 클래스타입, string, array
            string s2 = null;

            // NULL을 가질 수 없는 타입 (Value 타입, stack에 저장): 정수형(int, short, byte), 부동소수점형(bouble, float), 불리언(bool), 문자(char), 구조체(struct), 열거형(enum) 
            // Nullable 타입으로 변환하려면 자료형 뒤에?
            int? i3 = null;
                        
            bool? b2 = null;

            //int? 를 int로 할당
            Nullable<int> j = null; //Nullable<int>나 int? 이나 같다.
            // j = 10;
            // int k = j.Value;

    }

}