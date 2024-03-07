using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5_enum
{
    internal class enum_class
    {
        //enum문은 클래스 안이나 네임스페이스 내에서만 선언될 수 있다.
        ////즉, 메서드 안이나 속성 안에서는 선언되지 않는다.
        public enum Category
        {
            Cake,
            IceCream,
            Bread
        }
        public enum City
        {
            Seoul,   // 0
            Daejun,  // 1
            Busan = 5,  // 5
            Jeju = 10   // 10
        }
        [Flags]//enum의 각 멤버들은 각 비트별로 구분되는 값들(예: 1,2,4,8,...)을
               //갖을 수 있는데, 이렇게 enum 타입이 비트 필드를 갖는다는 것을
               //표시하기 위해 enum 선언문 바로 위에 [Flags] 라는 Attribute를 지정
        public enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

    }
}
