using System;

namespace Bank
{
    class SavingsAcct : Account {
        private decimal _interest;
        private int _counter;
        private int COUNTERLIMIT = 3;
        private decimal EXTRACHARGE = 2.00m;
        public decimal Balance {
            get; set;
        }
        public string AccountOwner {
            get => $"{Name} {Surname}";
        }
        public SavingsAcct (string name, string surname, decimal interest, decimal balance)
        : base (name, surname) {
            _interest = interest;
            Balance = balance;
        }
        public void Deposit (decimal money) {
            if (money <= 0) {
                throw new ArgumentException("Please deposit a quantity higher than zero.");
            }
            Balance += money;
            Console.WriteLine($"Deposited in Savings Account: {money:C2}");
        }
        public void Withdraw (decimal money) {
            // try to overdraw savings - this should be denied and print message
            if (money > Balance) {
                Console.WriteLine($"You cannot withdraw an amount higher than your savings account. Operation denied.");
            } else {
                _counter ++;
                Balance -= money;
                Console.WriteLine($"Withdrawed from Savings Account: {money:C2}");

                // More than 3 Savings withdrawals should result in 2.00 charge
                if (_counter > COUNTERLIMIT){
                    Balance -= EXTRACHARGE;
                    Console.WriteLine("Withdrawed more than three times. Charged $2.00 from Savings Account.");
                }
            }
        }
        public void ApplyInterest(){
            Balance += Balance * _interest;
            Console.WriteLine("Applied Interest in the Savings Account.");
        }
    }
}