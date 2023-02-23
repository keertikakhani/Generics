using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose option from below");
            Console.WriteLine("1.FindMaximumInteger\n2.FindMaximumFloat");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first integer number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second integer number");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third integer number");
                    int third = Convert.ToInt32(Console.ReadLine());

                    int value = MaximumInteger.MaximumIntegerNumber(first, second, third);
                    Console.WriteLine("{0} is largest ", value);
                    Console.WriteLine("****************************");
                    break;

                case 2:
                    Console.WriteLine("Enter first floating point number");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second floating point number");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter third floating point number");
                    double num3 = Convert.ToDouble(Console.ReadLine());

                    double value1 = MaximumFloat.MaximumFloatNumber(num1, num2, num3);
                    Console.WriteLine("{0} is largest ", value1);
                    Console.WriteLine("****************************");
                    break;
            }
               Console.ReadLine();
        }
    }
}

