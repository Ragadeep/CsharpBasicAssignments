using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class Factorial
    {
        public static int sampleFactorial(int factoralNumber)
        {
            int resultOne = factoralNumber;
            for (int i = 1; i < factoralNumber; i++)
            {
                resultOne *= i;
            }

            return resultOne;
        }
        public static void Main(string[] args)
        {
            int factoralNumber;
            Console.WriteLine("Enter the Number to perform the Factorial: ");
            factoralNumber = Convert.ToInt32(Console.ReadLine());

            int result = sampleFactorial(factoralNumber);
            Console.WriteLine($"Factorial of {factoralNumber} is  {result}");
            Console.ReadLine();
        }
    }
}
