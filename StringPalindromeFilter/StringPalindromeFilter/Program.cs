using System;
using System.Collections.Generic;
using System.Linq;

namespace StringPalindromeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<string>();
            var palindromeResultFirst = "isn't";
            var palindromeResultSecond = "isn't";
            var anagramResult = "aren't";

            for (var i = 0; inputList.Count < 2; i++)
            {
                Console.WriteLine("Please enter a word.");
                var userInput = Console.ReadLine();

                if (!inputList.Contains(userInput) && !int.TryParse(userInput, out _))
                {
                    inputList.Add(userInput);
                }
                else
                {
                    Console.WriteLine("Please enter a valid word, and make sure it is not the same as the previous one");
                }
            }

            if (IsPalindromeFirst(inputList))
            {
                palindromeResultFirst = "is";
            }

            if (IsPalindromeSecond(inputList))
            {
                palindromeResultSecond = "is";
            }

            if (IsAnagram(inputList))
            {
                anagramResult = "are";
            }

            Console.WriteLine("The first word " + palindromeResultFirst + 
                              " a palindromic word. The second word " + palindromeResultSecond + 
                              " a palindromic word. These words " + anagramResult + " anagrams of each other.");
        }

        static bool IsPalindromeFirst(List<string> inputList)
        {
            var isPalindromicWord = false;

            for (int i = 0; i < inputList[0].Length; i++)
            {
                for (int j = inputList[0].Length - 1; j >= 0; j--)
                {
                    if (inputList[0][i] == inputList[0][j])
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

        static bool IsPalindromeSecond(List<string> inputList)
        {
            var isPalindromicWord = false;

            for (int i = 0; i < inputList[1].Length; i++)
            {
                for (int j = inputList[1].Length - 1; j >= 0; j--)
                {
                    if (inputList[1][i] == inputList[1][j])
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

        static bool IsAnagram(List<string> inputList)
        {
            var isWordAnagram = false;

            if (inputList[0].Length != inputList[1].Length)
            {
                isWordAnagram = false;
            }
            else if (inputList[0].All(inputList[1].Contains) && inputList[1].All(inputList[0].Contains))
            {
                isWordAnagram = true;
            }
            else
            {
                isWordAnagram = false;
            }

            return isWordAnagram;
        }
    }
}
