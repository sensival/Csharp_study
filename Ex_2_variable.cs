using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2_variable
{
    internal class CSVar1//internal-> 같은 프로젝트 내에서만 가능
    {
        int globalVar;// 클래스 내 전역변수는 할당안하면 0
        const int MAX = 1024;

        public void printVar()
        {
            int localVar;

            localVar = 100; // 지역변수는 할당안하면 에러

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }
    internal class CSVar2
    {
        // 상수
        const int MAX_VALUE = 1024;

        // readonly 필드: 선언부나 클래스 생성자에서 그 값을 지정할 수 있고, 런타임시 값이 결정
        readonly int Max2;
        public CSVar2()//생성자
        {
            Max2 = 1;
        }
        public int Max2Value // 프로퍼티 추가
        {
            get { return Max2; }
        }

    }
}
