using System;
using System.Collections.Generic;
using System.Linq;

namespace StringPalindromeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word.");
            var userInput = Console.ReadLine();

            if (IsPalindrome(userInput))
            {
                Console.WriteLine("This word is a palindrome.");
            }
            else
            {
                Console.WriteLine("This word is not a palindrome.");
            }
        }

        static bool IsPalindrome(string userInput)
        {
            var charList = new List<char>();
            var isPalindromicWord = false;

            foreach (var letter in userInput)
            {
                charList.Add(letter);
            }

            for (int i = 0; i < charList.Count; i++)
            {
                for (int j = charList.Count - 1; j >= 0; j--)
                {
                    if (charList[i] == charList[j])
                    {
                        isPalindromicWord = true;
                    }
                    else
                    {
                        isPalindromicWord = false;
                    }

                    i++;
                }
            }

            return isPalindromicWord;
        }
    }
}
