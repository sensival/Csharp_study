using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6_operator
{
    internal class operator_cls
    {
        // 다른 연산자들 모두 C++같음
        //??연산자
        //변수 str가 null 이면 "(널)" 이라는 문자열을 s 에 대입한다. null 이 아니면 str의 값을 s 에 대입.
        public void doublequestion(string str)
        {
            str = str ?? "(널)";
            Console.WriteLine(str);
        }
        
        
    }
}
