using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class program7
    {
        static void Main(String[] args)
        {
            int n = 5;
            int f = 1;
            for (int i = 0; i < n; i++)
            {
                f = f * (n - 1);
            }
            Console.WriteLine("The factorial of the given number is: " + f);
        }
    }
}
