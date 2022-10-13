using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Calculator
    {
        public static void Calculation(int a, int b, string operation)
        {
            switch (operation)
            {
                case "+":
                    int result1 = a + b;
                    Console.WriteLine(result1);
                    break;
                case "-": 
                    int result2 = a - b;
                    Console.WriteLine(result2);
                    break;
                case "*":
                        int result3 = a * b;
                    Console.WriteLine(result3);
                    break;
                case "/" :
                     int result4 = a * b;
                    Console.WriteLine(result4);
                    break;

                
          







            }
        }

    }
}

