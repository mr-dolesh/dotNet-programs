using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class program03
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Positive number");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
        }
    }
}
