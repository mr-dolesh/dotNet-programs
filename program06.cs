using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class program6
    {
        public static string Odd { get; private set; }

        static void Run(String[] args)
        {
            int N;
            Console.WriteLine("Enter a number:");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("The given number is Even: " + i);
                }
                else
                {
                    Console.WriteLine("The given Number is Odd:" + Odd);
                }
            }
        }
    }
}
