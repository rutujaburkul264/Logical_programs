using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void primenNo()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number {0} is Not Prime Number",num);
                    break;
                }
                    Console.WriteLine("Number {0} Prime Number",num);
                Console.ReadLine();
            }
        }
    }
}
