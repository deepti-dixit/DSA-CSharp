using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Basics
{
    internal class checkOddEven
    {
        public static void checkEvenOdd()
        {
            int num;
            while (true)
            {
                Console.WriteLine("Enter your Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Your Number Even is {num}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your Number is Odd.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Positive Number. Try Again");

                }
            }


        }
    }
}
