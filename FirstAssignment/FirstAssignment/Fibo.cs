using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class Fibo
    {
        public static int sampleFibo(int fibonaci)
        {
            int p = 0;
            int q = 1;
            for (int i = 0; i < fibonaci; i++)
            {
                int temp = p;
                p = q;
                q = temp + q;
            }
            return p;
        }
        public static void Main(string[] args)
        {
            int fibonaci;
            Console.WriteLine("Input number of terms for the Fibonacci series : ");
            fibonaci = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\n The Fibonacci series of {fibonaci} terms is : ");
            for (int i = 0; i < fibonaci; i++)
            {
                Console.Write("{0} ", sampleFibo(i));
            }
            Console.ReadLine();
        }
    }
}
