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

        public static bool CheckPalindrome(this string input , out string reverseValue)
        {
            string rev=string.Empty;
            char[] p = input.ToCharArray();
            string rev1 = new string(input.Reverse().ToArray());
            string rev2 = ReverseString(input);
            for (int i = input.Length-1; i>= 0; i--)
            {
                rev = rev + p[i];
            }
            //reverseValue = rev;
            //reverseValue = rev1;
            reverseValue = rev2;
            if (rev.Equals(input))
                return true;
            else
                return false;
            
        }

        public static bool isStringPalindrome(this string input)
        {
            //var reversed = new string(Enumerable.Range(1, input.Length).Select(i => input[input.Length - i]).ToArray());
            var reversed1 = new string(input.ToCharArray().Reverse().ToArray());
            return String.Compare(input, reversed1, true) == 0;
            //return String.Compare(input, reversed, true) == 0;
        }

        public static string ReverseString(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());

        }

    }
}
