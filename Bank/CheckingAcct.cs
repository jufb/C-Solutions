using System;

namespace Bank
{
    class CheckingAcct : Account {
        private decimal EXTRACHARGE = 35.00m;
        public decimal Balance {
            get; set;
        }
        public string AccountOwner {
            get => $"{Name} {Surname}";
        }
        public CheckingAcct (string name, string surname, decimal balance)
        : base (name, surname) {
            Balance = balance;
        }
        public void Deposit (decimal money) {
            if (money <= 0) {
                throw new ArgumentException("Please deposit a quantity higher than zero.");
            }

            Balance += money;
            Console.WriteLine($"Deposited in Checking Account: {money:C2}");
        }
        public void Withdraw (decimal money) {
            // try to overdraw checking - should result in extra charge a $35 fee
            if (money > Balance) {
                Balance -= EXTRACHARGE;
                Console.WriteLine($"Overdrawn ammount. Applied an extra charge of $35.00: {Balance:C2}");
            }

            Balance -= money;
            Console.WriteLine($"Withdrawed from Checking Account: {money:C2}");
        }
    }
}