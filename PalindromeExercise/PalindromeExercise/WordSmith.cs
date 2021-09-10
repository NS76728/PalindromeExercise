using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
       
        public bool IsAPalindrome(string input)
        {
          
            char[] ch = input.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool b = input.Equals(rev, StringComparison.OrdinalIgnoreCase);

            return b;
        }
    }
}
