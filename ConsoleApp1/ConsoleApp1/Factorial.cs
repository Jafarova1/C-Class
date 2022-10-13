using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Factorial
    {
        int n = 3;
       
        
        public static void CheckFactorial(int n)
        {
            int fact = 1;
            
            for(int i = 1; i <= n; i++)
            {
              fact=fact* i;
                Console.WriteLine(fact);
                
            }
        }
    }
}
