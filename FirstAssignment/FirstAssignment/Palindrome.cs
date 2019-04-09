using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    class Palindrome
    {
        public static void simplePalindrome(int palindromeCheck)
        {
            int remainder;
            int reversedInteger = 0;
            int tempPalindrome = palindromeCheck;
            while (tempPalindrome != 0)
            {
                remainder = tempPalindrome % 10;
                reversedInteger = reversedInteger * 10 + remainder;
                tempPalindrome /= 10;
            }
            if (palindromeCheck == reversedInteger)
            {
                Console.WriteLine("Entered Number is Palindrome Number");
            }
            else
            {
                Console.WriteLine("Entered Number is Not Palindrome Number");
            }

        }
        public static void Main(string[] args)
        {
            int palindromeCheck;
            Console.WriteLine("Enter a Number to check Pallindrome or Not : ");
            palindromeCheck = Convert.ToInt32(Console.ReadLine());
            simplePalindrome(palindromeCheck);
            Console.ReadLine();
        }
    }
}
