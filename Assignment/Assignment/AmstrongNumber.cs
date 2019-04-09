//Check given number is amstrong number or not.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AmstrongNumber
    {
        //Function to check amstrong number.
        public static void amstrongNumber(int number)
        {
            int originalNumber;
            int remainder, result = 0;
            int n = 0;
            originalNumber = number;
            //To store given integer digit counter.
            while (originalNumber != 0)
            {
                originalNumber /= 10;
                ++n;
            }

            originalNumber = number;

            while (originalNumber != 0)
            {
                remainder = originalNumber % 10;                 // Storing remainder in each iteration.
                result = result + (int)Math.Pow(remainder, n);  
                originalNumber /= 10;
            }
            if (result == number)
            {
                Console.WriteLine("Given Number is amstrong Number");
            }
            else
            {
                Console.WriteLine("Given number is not an Armstrong number.");
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Number to check amstrong or not: ");
            number = Convert.ToInt32(Console.ReadLine());
            amstrongNumber(number);
            Console.ReadLine();
        }
    }
}
