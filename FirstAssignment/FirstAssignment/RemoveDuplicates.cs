using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 3, 4 };
            int[] q = values.Distinct().ToArray();
            foreach (int value in q)
            {
                Console.WriteLine($"{value} ");
            }
            Console.ReadLine();
        }
    }
}
