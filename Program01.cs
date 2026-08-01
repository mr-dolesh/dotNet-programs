using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program01
    {
        static void Run(string[] args)
        {    
            
            String name;
            int rollno;
            int marks;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter the roll number: ");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks: ");


            Console.WriteLine("---------Dispaly information-----------");
            Console.WriteLine(name);
            Console.WriteLine(rollno);
            Console.WriteLine(marks);
         
        }
    }
}
