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
                Console.WriteLine("Ënter the choice" + '\n' + "1.Abbreviation" + '\n' + "2.Palindrome" +
                    "\n" + "3.Exit");

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
                        Console.WriteLine("Enter the Value to check for palindrome");
                        string value1 = Console.ReadLine();
                        obj.isStringPalindrome(value1);
                        repeatQues = true;

                        break;
                    case "3":

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
            string abbr = input.Abbreviation();
            Console.WriteLine(abbr);
            Console.ReadLine();
        }

        private void CallPalindrome(string input)
        {
            string result = input.Palindrome();

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private void isStringPalindrome(string input)
        {
            bool b = false;
            if (b == true)
            {
                Console.WriteLine("Palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not a palindrome");
                Console.ReadLine();
            }
        }

    }
}

