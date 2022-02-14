namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(false);
        }

        static void Menu(Boolean resp) {
            if(resp) {
                Console.WriteLine("\nWhat operation would you like to do?\n");
            }
            else {
                Console.Clear();
                Console.WriteLine("__________________________________\nWelcome to the Calculator!\n__________________________________\n\nWhat operation would you like to do?\n");
            }

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Divide");
            Console.WriteLine("4 - Multiply");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("__________________________________\n");
            
            try {
                short e = short.Parse(Console.ReadLine());

                if(e == 0) {
                    Console.WriteLine("Thank you for using my Calculator!\n");
                    System.Environment.Exit(0);
                }
                else if(e <= 4 ) {
                    CalcArgs(e);
                }
                else {
                    throw new Exception();
                }
            }
            catch (Exception) {
                Console.WriteLine("Please enter a valid value.");
                Menu(true);
            }
        }
        static void CalcArgs(short e) {
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = 0;

            Operations o = new Operations();

            switch(e) {
                case 1: result = o.Sum(v1, v2); break;
                case 2: result = o.Subtract(v1, v2); break;
                case 3: result = o.Divide(v1, v2); break;
                case 4: result = o.Multiply(v1, v2); break;
                default: Menu(true); break;
            }

            Console.WriteLine("The result is: " + result);
            Menu(true);
        }
    }
}