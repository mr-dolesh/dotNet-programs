using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class program02
    {
        static void Run(String[] args)
        {
            Console.Write("Enter the number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2; ;
            int quotient = number1 / number2;
            int remainder = number1 % number2;

            Console.WriteLine("---------Display results-----------");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }
    }
}
