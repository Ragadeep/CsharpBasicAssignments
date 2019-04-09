// Program to convert Decimal Number to Binary Number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NumberConversion
    {
        // Function to convert Decimal to Binary.
        public static void decToBinary(int decimalNumber)
        {
            //Array to store binary Number.
            int[] binaryNumber = new int[1000];

            // counter for binary array.
            int i = 0;
            while(decimalNumber > 0)
            {
                // Storing remainder in binary  array.
                binaryNumber[i] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                i++;
            }

            //print binary array in reverse order.
            for (int j = i-1; j >= 0; j--)
            {
                Console.Write(binaryNumber[j]);
            }
        }
        static void Main(string[] args)
        {
            int decimalNumber;
            Console.WriteLine("Enter a decimal number to convert into Binary: ");
            decimalNumber = Convert.ToInt32(Console.ReadLine());
            decToBinary(decimalNumber);
            Console.ReadLine();
        }
    }
}
