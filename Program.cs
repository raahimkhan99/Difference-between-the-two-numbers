using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q. Write a program that takes input the tow numbers and tell their difference
            double First_Num, Sec_Num, Diff; //Diff = Difference
            Console.WriteLine("\t\t\t\t\tDifference Of Two Numbers");
            Console.WriteLine("\t\t\t\t\t=========================" + "\n\n\n");
            Console.WriteLine("Enter First Number");
            Console.WriteLine("------------------");
            First_Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Enter Second Number:");
            Console.WriteLine("--------------------");
            Sec_Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            if (Sec_Num > First_Num)
            {
                Diff = Sec_Num - First_Num;
                Console.WriteLine("Difference: " + (Diff));
                Console.WriteLine("\n");
            }
            else 
            {
                Diff = First_Num - Sec_Num;
                Console.WriteLine("Difference: " + (Diff));
                Console.WriteLine("\n");
            }
        }
    }
}
