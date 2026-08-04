using System;

namespace Assignment
{
    internal class Program05
    {
        public static void Run(string[] args)
        {
            Console.Write("Enter the number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1: Addition\n2: Subtraction\n3: Multiplication\n4: Division");
            Console.Write("Enter choice (1-4): ");
            int c = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Console.WriteLine("The addition is " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("The difference is " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("The product is " + (a * b));
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                       
                        Console.WriteLine("The division is " + ((double)a / b));
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a number between 1 and 4.");
                    break;
            }
        }
    }
}