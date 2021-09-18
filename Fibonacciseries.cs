using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibSeries
    {
        public static void FibonacciSeries()
        {
            int num1 = 0, num2 = 1, num3, i, number;
            Console.WriteLine("Enter the numbers");
            number = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");

            for  (i = 2;i < number;++i)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3+" ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
