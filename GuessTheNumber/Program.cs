using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the game greeting and instructions
            Menu();
        }
        static int theNumber = new Random().Next(20);
        static int counter = 1;
        static int guess = 0;

        static void Menu(){
            try {
                Console.WriteLine("Let's Play 'Guess the Number'!");
                Console.WriteLine("I'm thinking of a number between 0 and 20.");
                Console.WriteLine("Enter your guess, or -1 to give up.");

                Guesses();
            }
            catch {
                Console.WriteLine("Inform a valid input.");
                Menu();
            }
        }

        static void Guesses(){
            // Keep track of the number of guesses and the current user guess
            var entry_value = Console.ReadLine();
            bool succeeded = Int32.TryParse(entry_value, out guess);
            if(!succeeded){
                Console.WriteLine("Please inform numbers only.");
                Guesses();
            }

            //Validates if user wants to exit
            IsExit(guess.ToString());

            if(guess > theNumber){
                Console.WriteLine($"Try again! The number is LOWER than {guess}");
                counter ++;
                Guesses();
            }
            if(guess < theNumber){
                Console.WriteLine($"Try again! The number is HIGHER than {guess}");
                counter ++;
                Guesses();
            }
            if(guess == theNumber){
                Console.WriteLine($"You got this! You guessed in {counter} times!");
                
                //Validates if user wants to exit
                Console.WriteLine("Want to try again? y/n");
                string yn = Console.ReadLine().ToLower();
                IsExit(yn);
            }
        }

        static void IsExit(string input) {
            switch (input) {
                case "y": 
                case "yes":
                    theNumber = new Random().Next(20);
                    counter = 1;
                    Menu();
                    break;
                case "n":
                case "no":
                    Console.WriteLine("Thank you! Bye!");
                    Environment.Exit(1);
                    break;
                case "-1":
                    Console.WriteLine($"The number I was thinking was {theNumber}.\nThank you, bye!");
                    Environment.Exit(1);
                    break;
                default: 
                    break;
            }
        }
    }
}