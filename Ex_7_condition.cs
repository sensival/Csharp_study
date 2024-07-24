using Ex_7_condition;
using System;

namespace Ex_7_condition
{
    internal class condition_cls
    {
        public void ifelse()
        {
            // Declare the variable val
            int val;

            // Read input from the console
            string input = Console.ReadLine();
            int a;

            // Try to parse the input to an integer
            if (int.TryParse(input, out a))
            {
                if (a >= 0)
                {
                    val = a;
                }
                else
                {
                    val = -a;
                }
                Console.Write(val);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        public void switchcase()
        {
            // Declare the variable price
            int price;

            // Read input from the console
            string category = Console.ReadLine();
            switch (category)
            {
                case "사과":
                    price = 1000;
                    break;
                case "딸기":
                    price = 1100;
                    break;
                case "포도":
                    price = 900;
                    break;
                default:
                    price = 0;
                    break;
            }
            Console.Write(price);
        }
    }
}

