using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third integer number");
            int third = Convert.ToInt32(Console.ReadLine());

            int value = MaximumInteger.MaximumIntegerNumber(first, second, third);
            Console.WriteLine("{0} is largest ", value);
            Console.WriteLine("****************************");

            Console.ReadLine();
        }
    }
}

