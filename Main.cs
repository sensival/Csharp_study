using System;
using Ex_1_datatype;
using Ex_2_variable;

namespace Csharp_study
{
    class Program
    {
        public static void Main()
        {
            CSVar1 csvar1 = new CSVar1();
            csvar1.printVar();

            CSVar2 csvar2 = new CSVar2();
            Console.WriteLine(csvar2.Max2Value); 

            
        }
    }
}