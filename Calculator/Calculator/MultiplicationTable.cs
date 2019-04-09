using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MultiplicationTable
    {
        public static void sampleMultiTable(int mutliTableNumber)
        {
            for (int i=1; i<11; i++)
            {
                Console.WriteLine($"{mutliTableNumber} * {i} = {mutliTableNumber * i}");
            }
        }
        static void Main(string[] args)
        {
            int mutliTableNumber;
            Console.WriteLine("Enter the number to display Multipication Table");
            mutliTableNumber = Convert.ToInt32(Console.ReadLine());
            sampleMultiTable(mutliTableNumber);

            Console.ReadLine();
        }
    }
}
