namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(false);
        }

        ///<summary>
        /// Calls the Menu of the application. Define 'False' if its the first call. Define 'True' to show greetings.
        ///</summary>
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
            Console.WriteLine("5 - Square Root");
            Console.WriteLine("6 - Fibonacci");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("__________________________________\n");
            
            try {
                string? e = Console.ReadLine();

                switch (e) {
                    case "0": 
                        Console.WriteLine("Thank you for using my Calculator!\n");
                        System.Environment.Exit(0);
                        break;
                    case "1": case "2": case "3": case "4": case "5": case "6": CalcArgs(short.Parse(e)); break;
                    default: throw new Exception();
                }
            }
            catch (Exception) {
                Console.WriteLine("Please enter a valid value.");
                Menu(true);
            }
        }
        static void CalcArgs(short e) {
            decimal v1 = 0;
            decimal v2 = 0;
            string sequence = "";
            Operations o = new Operations();

            Console.WriteLine("Inform a value: ");

            if (o.IsCommonOperator(e)) {
                v1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Inform another value: ");
                v2 = decimal.Parse(Console.ReadLine());
                o.Values = (v1, v2);
            }

            switch(e) {
                case 1: o.Result = (decimal)o.Sum(); break;
                case 2: o.Result = (decimal)o.Subtract(); break;
                case 3: o.Result = (decimal)o.Divide(); break;
                case 4: o.Result = (decimal)o.Multiply(); break;
                case 5: 
                    double root = double.Parse(Console.ReadLine());
                    o.Result = (decimal)o.SquareRoot(root);
                    break;
                case 6: 
                    int n = int.Parse(Console.ReadLine());
                    (o.Result, sequence) = o.Fibonacci(n);
                    break;
                default: Menu(true); break;
            }

            Console.WriteLine($"The result is: {o.Result} {sequence}");
            Menu(true);
        }
    }
}