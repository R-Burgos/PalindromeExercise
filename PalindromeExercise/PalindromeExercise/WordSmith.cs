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
        //    if (word == null || word.Length == 0)
        //    {
        //        return false;
        //    }
        //    char[] chars = word.ToLower().ToCharArray();
        //    Array.Reverse(chars);
        //    return (new string(chars) == word.ToLower());

            //var reversed = "";
            //for (var i = word.Length - 1; i >= 0; i--)
            //{
            //    reversed += word.ToLower()[i]; 
            //}
            //if (reversed == word.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

           // return (word.Length == 0) ? word?.ToLower().SequenceEqual(word?.ToLower().Reverse()) ?? false : false;

            return (word?.Length == 0) ? false : word?.ToLower().SequenceEqual(word?.ToLower().Reverse()) ?? false;
        }
    }
}
