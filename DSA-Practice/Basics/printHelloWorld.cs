using System;

namespace DSA_Practice.Basics
{
    internal class printHelloWorld
    {
        public static void SayHello()
        {
            Console.WriteLine("Welcome To My World!");
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
        }
    }
}
