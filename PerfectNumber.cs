using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void perfectNumber()
        {
            int no, sum = 0, x;
            Console.WriteLine("Enter the number");
            no = int.Parse(Console.ReadLine());
            x = no;

            for (int i=1;i<no;i++)
            {
                if(no % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == x)
            {
                Console.WriteLine("Pefect Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
                Console.ReadLine();
            }
        }
    }
}
