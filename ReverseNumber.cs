using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void ReverseNo()
        {
            Console.WriteLine("Enter a number to reverse");
            int Num = int.Parse(Console.ReadLine());
            int Reverse = 0;

            while (Num > 0)
            {
                int remainder = Num % 10;
                Reverse = (Reverse * 10) + remainder;
                Num = Num / 10;
            }
            Console.WriteLine("Reverse number is {0}",Reverse);
            Console.ReadLine();
        }
    }
}
