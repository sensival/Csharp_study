using System;
using Ex_1_datatype;

namespace Csharp_study
{
    class Program
    {
        public static void Main()
        {
            print_test testInstance = new print_test();
            testInstance.printMsg();
            testInstance.print_repetitive();

            data_types dataInstance = new data_types();
            dataInstance.printMax();
            dataInstance.printMin();
        }
    }
}