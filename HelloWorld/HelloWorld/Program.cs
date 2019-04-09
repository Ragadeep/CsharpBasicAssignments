
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int calOperation;

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Divide");
            calOperation = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You entered :{0}", calOperation);
            Console.ReadLine();

        }
    }
}
