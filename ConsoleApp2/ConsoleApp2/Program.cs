using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Enter operator: ");
            string operation= Console.ReadLine();
            Calculator calculator1 = new Calculator();
            Calculator.Calculation(a, b, operation);
            
            
            
            


        }
    }
}
