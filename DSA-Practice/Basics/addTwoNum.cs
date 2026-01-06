using System;

namespace DSA_Practice.Basics
{
    public class AddTwoNumbers
    {
        public static void Run()
        {
            int a, b, c;

            Console.Write("Enter 1st Number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            b = int.Parse(Console.ReadLine());

            c = a + b;

            Console.WriteLine("Sum of 1st and 2nd number: " + c);
        }
    }
}
