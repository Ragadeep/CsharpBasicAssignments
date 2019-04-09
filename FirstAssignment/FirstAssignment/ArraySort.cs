using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class ArraySort
    {
        public static void Main(string[] args)
        {
            int[] values = { 4, 7, 2, 0 };
            Array.Sort(values);
            foreach(int value in values)
            {
                Console.WriteLine($"{value} ");
            }
            Console.ReadLine();
        }
    }
}
