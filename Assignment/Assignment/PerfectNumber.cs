// Program to check given integer is perfect number are not.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PerfectNumber
    {
        // Function to check perfect or not.
        public static void perfectNumber(int number)
        {
            int i;
            int sum = 0;
            for(i=1; i<number; i++)
            {
                if(number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == number)
            {
                Console.WriteLine("Given number is perfect number");
            }
            else
            {
                Console.WriteLine("Given number is not perfect numbet");
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number to check perfect or not: ");
            number = Convert.ToInt32(Console.ReadLine());
            perfectNumber(number);
            Console.ReadLine();
        }
    }
}
