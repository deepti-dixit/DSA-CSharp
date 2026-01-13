using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Pattern
{
    internal class squarePattern
    {
        public static void printPattern()
        {
            int num;
            Console.WriteLine("Enter your star number.");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= num; i++)
            {
                for(int j=1; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
