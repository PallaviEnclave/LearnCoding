using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtClassString
{
    public static class ExtensionMethodStringType
    {
        public static string Abbreviation(this string input)
        {
            string[] word = input.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToUpper().Equals("OF") || word[i].ToUpper().Equals("AND") || word[i].ToUpper().Equals("THE"))
                    continue;
                sb.Append(word[i].Substring(0, 1).ToUpper() + '.');
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static string Palindrome(this string input)
        {
            char[] s = input.ToCharArray();
             s.Reverse();
            string p = s.ToString();
            if (input.Equals(p))
                return "palindrome";
            else
                return "not palindrome";
        }

        public static bool isStringPalindrome(this string input)
        {
            var reversed = new string(Enumerable.Range(1, input.Length).Select(i => input[input.Length - i]).ToArray());
            return String.Compare(input, reversed, true) == 0;
        }

    }
}
