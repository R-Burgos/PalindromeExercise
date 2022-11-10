using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        { 
            char[] chars = word.ToLower().ToCharArray();
            Array.Reverse(chars);
            return (new string(chars) == word.ToLower());
        }
    }
}
