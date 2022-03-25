namespace Calculator
{
    public class Operations
    {
        public (decimal v1, decimal v2) Values {
            get; set;
        }
        public decimal Result {
            get; set;
        }
        public decimal Sum() {
            Result = Values.v1 + Values.v2;
            return Result;
        }

        public decimal Subtract() {
            Result = Values.v1 - Values.v2;
            return Result;
        }

        public decimal Divide() {
            Result = Values.v1 / Values.v2;
            return Result;
        }
        public decimal Multiply() {
            Result = Values.v1 * Values.v2;
            return Result;
        }
        public decimal SquareRoot(double v1) {
            Result = (decimal)Math.Sqrt(v1);
            return Result;
        }
        
        ///<summary>
        /// Count the Fibonacci sequence up to the informed number.
        ///</summary>
        public (int number, string sequence) Fibonacci(int n) {
            int x = 0;
            int y = 1;
            int z = 0;
            int number = n - 1; //because it starts at zero
            string result = $"and the sequence up to {n} is: 0 1";
            if (IsLowerThanTwo(n)) {
                result = "Inform a higher number!";
            }

            for (int i = 2; i <= number; i++)
            {
                z = x + y; //0+1
                result += $" {z}";
                x = y; //1
                y = z; //sum
            }

            return (z, result);
        }

        ///<summary>
        /// Validates if the entered menu is between 1 and 4.
        ///</summary>`
        public Boolean IsCommonOperator(short e) {
            bool valid = false;
            if (e >= 1 && e <= 4)
            {
                valid = true;
            }
            return valid;
        }
        
        ///<summary>
        /// Validates if the entered number is lower than two or negative.
        ///</summary>`
        Boolean IsLowerThanTwo(int n)
        {
            bool result = false;
            if(n <= 2 || n < 0) {
                result = true;
            }
            return result;
        }
    }
}