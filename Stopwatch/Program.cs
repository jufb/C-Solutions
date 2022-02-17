namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(false); //Start with a Welcome!
        }

        ///<summary>
        /// Open the Menu of the application.
        /// Parameter true is used to show the greetings.
        ///</summary>
        static void Menu(Boolean resp)
        {
            try
            {
                if (resp) //First time accessing the system
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to my StopWatch!");
                }

                Console.WriteLine("\n\nWhat would you like to count?\n");
                Console.WriteLine("S - Second");
                Console.WriteLine("M - Minute");
                Console.WriteLine("0 - Exit");
                
                string type = Console.ReadLine().ToLower();

                if(type.Contains("0"))
                {
                    Console.WriteLine("Thank you for using my Stopwatch!\n");
                    System.Environment.Exit(0);
                }

                Console.WriteLine("\nFor how long would you like to count?");
                int time = int.Parse(Console.ReadLine());

                int result = DefineTime(type, time);

                Console.WriteLine("You selected " + time.ToString() + type);
                Thread.Sleep(2500);

                Console.WriteLine("Stopwatch is going to start:\n");
                Thread.Sleep(2500);

                Start(result); //Start the counter
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid value.");
                Menu(false); //No need to welcome, just keep asking
            }
        }


        ///<summary>
        /// Detect the type in Second or Minute and calculate the time given.
        ///</summary>
        private static int DefineTime(string type, int time)
        {
            int multiplier = 1; //minute timer
            int result = 0;

            if(type.Contains("m"))
                multiplier = 60; //multiplier per minute

            return result = time * multiplier; //multiply the time given by the user
        }

        ///<summary>
        /// Start the Stopwatch.
        ///</summary>
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("\nStopwatch stopped.\n");
            Menu(false); //Continue with the menu again
        }
    }
}