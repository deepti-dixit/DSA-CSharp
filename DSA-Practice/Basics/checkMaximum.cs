using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Basics
{
    internal class checkMaximum
    {
        public static void check()
        {
            int a, b, c;
            Console.WriteLine("Enter 1st Number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number ");
            c = Convert.ToInt32(Console.ReadLine());

            //Find maximum of two numbers
            if (a > b)
            {
                Console.WriteLine("1st number is max number");
            }
            else
            {
                Console.WriteLine("2nd number is max number");
            }


            //Find maximum of three numbersKD
            if (a > b && a > c)
            {
                Console.WriteLine("1st number is max number");
            }else if (b > a && b > c)
            {
                Console.WriteLine("2nd number is max number");
            }
            else
            {
                Console.WriteLine("3rd number is max number");
            }


            //2nd method
            Console.WriteLine("Enter 1st Number:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd Number:");
            int z = Convert.ToInt32(Console.ReadLine());

            int max = x;

            if (b > max)
                max = y;

            if (c > max)
                max = z;

            Console.WriteLine("Maximum number is: " + max);
        }
    }
}
