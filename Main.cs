using System;

namespace Csharp_study
{
    class Program
    {
        public static void Main()
        {
            Ex_1_datatype.print_test testInstance = new Ex_1_datatype.print_test();
            testInstance.printMsg();
            testInstance.print_repetitive();

            Ex_1_datatype.data_types dataInstance = new Ex_1_datatype.data_types();
            dataInstance.printMax();
            dataInstance.printMin();
        }
    }
}