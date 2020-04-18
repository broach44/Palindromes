using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Flipper
    {
        public bool WordFlip(string someWord)
        {

            var wordToTest = someWord.ToLower().Replace(" ", "").Replace("!", "").Replace(",", "");
            var wordCharArray = wordToTest.ToCharArray();
            var wordStringArray = Array.ConvertAll(wordCharArray, char.ToString);
            Array.Reverse(wordStringArray);
            var reversedWord = string.Join("", wordStringArray);

            if (reversedWord == wordToTest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
