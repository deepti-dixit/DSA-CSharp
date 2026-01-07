using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Basics
{
    internal class checkPositiveNegative
    {
        public static void check()
        {
            int num;
            Console.WriteLine("Enter your number ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num != 0)
            {
                if (num > 0)
                {
                    Console.WriteLine("Your number is Positive");
                }
                else
                {
                    Console.WriteLine("Your number is Negative");
                }
            }
            else
            {
                Console.WriteLine("Your Number is Zero.");
            }
        }
    }
}
