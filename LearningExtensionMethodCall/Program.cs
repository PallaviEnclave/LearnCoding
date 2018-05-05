using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtClassString;


namespace LearningExtensionMethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string UserChoice;
            bool repeatQues;
            do
            {
                Console.WriteLine("Ënter the choice" + '\n' + "1.Abbreviation" + '\n' + 
                    "2.Palindrome check by LinQ" + "\n" + "3.Palindrome check by string reverse compare" +
                    "\n" + "4.Exit");

                UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    case "1":
                        Console.WriteLine("Enter the Value to extract the abbreviation");
                        string value = Console.ReadLine();
                        obj.CallAbbreviation(value);
                        repeatQues = true;

                        break;
                    case "2":
                        Console.WriteLine("Enter the Value to check for palindrome by LinQ method");
                        string strvalue = Console.ReadLine();
                        obj.isStringPalindrome(strvalue);
                        repeatQues = true;

                        break;
                    case "3":
                        Console.WriteLine("Enter the Value to check for palindrome by string reverse comparison method");
                        string value1 = Console.ReadLine();
                        obj.CheckPalindrome(value1);
                        repeatQues = true;

                        break;
                    case "4":

                        repeatQues = false;
                        break;
                    default:
                        Console.WriteLine("Ënetered Value is out of choice. Please enter a valid choice" +
                            "from the list of displayed options");
                        repeatQues = true;

                        break;
                }
            } while (repeatQues);

        }

        private void CallAbbreviation(string input)
        {
           // string abbr = input.Abbreviation();
            Console.WriteLine("Abbreviation of" + '\t' + input + '\t' + "is" +'\t' + input.Abbreviation());
            Console.ReadLine();
        }

        private void CheckPalindrome(string input)
        {
            //string result = input.Palindrome();

            Console.WriteLine(input.CheckPalindrome(out string revstring));
            Console.WriteLine(revstring);
            Console.ReadLine();
        }

        private void isStringPalindrome(string input)
        {
            if (input.isStringPalindrome() == true)
            {
                Console.WriteLine(input + '\t'+"is a Palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(input + '\t' + "is not a Palindrome");
                Console.ReadLine();
            }
        }

    }
}

