using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Palindrome {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu(){
            try {
                Console.WriteLine("Hello, please inform a word or phrase to check if it's Palindrome or type 'exit':");
                
                string input = Console.ReadLine().ToLower();
                
                (bool result, int size) answer = IsPalindrome(input);

                Console.WriteLine("This {0} a Palindrome! And its size is {1}.", answer.result ? "IS" : "is NOT", answer.size);
                
                //Validates if user wants to continue or exit
                Console.WriteLine("Want to try again? y/n");
                string yn = Console.ReadLine().ToLower;
                IsExit(yn);
            }
            catch {
                Console.WriteLine("Please input characters only.");
                Menu();
            }
        }

        static (bool r, int s) IsPalindrome(string input) {
            input = Regex.Replace(input, @"[\p{P}\s*\d*]", "");

            //Validates if user entered Exit
            IsExit(input);

            char[] listinput = input.ToCharArray();
            string reverse = string.Empty;

            for(int i = listinput.Length - 1; i > -1; i--) {
                reverse += listinput[i];
            }

            Console.WriteLine($"I have transformed your input '{input}' into '{reverse}'");
            int size = input.Length;
            bool result = false;

            if (input == reverse) {
                result = true;
            }

            return (result, size);
        }

        static void IsExit(string input) {
            switch (input) {
                case "y": 
                case "yes":
                    Menu();
                    break;
                case "n":
                case "no":
                case "exit":
                    Console.WriteLine("Thank you! Bye!");
                    Environment.Exit(1);
                    break;
                default: 
                    break;
            }
        }
    }
}