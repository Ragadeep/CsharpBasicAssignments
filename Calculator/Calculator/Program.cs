using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static int simpleCalculator(int firstNumber, int secondNumber, int calOperation)
        {
            switch (calOperation)
            {
                case 1:
                    int addition = firstNumber + secondNumber;
                    return addition;
                case 2:
                    int subtraction = firstNumber - secondNumber;
                    return subtraction;
                case 3:
                    int multiplication = firstNumber * secondNumber;
                    return multiplication;
                case 4:
                    int divide = firstNumber / secondNumber;
                    return divide;
                default:
                    Console.WriteLine("You Enter Wrong Option");
                    break;
            }

            return calOperation;
        }
        static void Main(string[] args)
        {
            int calOperation;
            int firstNumber;
            int secondNumber;

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Divide");
            calOperation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You entered :{calOperation}");
            Console.WriteLine("Enter First Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int i=simpleCalculator(firstNumber, secondNumber, calOperation);
            Console.WriteLine($"\nYour Answer: {i}");
            Console.ReadLine();

        }
    }
}
