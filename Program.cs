using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a single word: ");
            string word = Console.ReadLine();

            if (IsPalindrome(word))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
        static bool IsPalindrome(string input)
        {
            int left = 0; 
            int right = input.Length - 1; 

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false; 
                }
                left++; 
                right--; 
            }
            return true; 
        }
    }
}
