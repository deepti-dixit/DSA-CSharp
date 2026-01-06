using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Basics
{
    internal class basicCalculator
    {
        public static void calculator()
        {
            float a, b;

            Console.WriteLine("Enter your 1st Number: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Operation: ");
            string opr = Console.ReadLine();
            Console.WriteLine("Enter your 2nd Number: ");
            b = float.Parse(Console.ReadLine());

            float sum = a + b;
            float difference = a - b;
            float product = a * b;
            float division = a / b;

            switch (opr)
            {
                case "+":
                    Console.WriteLine($"Addition of 1st and 2nd Number is {sum}");
                    break;
                case "-":
                    Console.WriteLine($"Difference of 1st and 2nd Number is {difference}");
                    break;
                case "*":
                    Console.WriteLine($"Product of 1st and 2nd Number is {product}");
                    break;
                case "/":
                    Console.WriteLine($"Division of 1st and 2nd Number is {division}");
                    break;
                default:
                    Console.WriteLine($"Enter Valid Number");
                    break;
            }

        }
    }
}
