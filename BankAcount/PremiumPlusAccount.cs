using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    class PremiumPlusAccount:IBankAccount
    {
        public string AccountType { get; } = "Premium Plus";
        public double Balance { get; set; } = 0;
        public int OverdraftLimit { get; } = 10000;
        public string CCType { get; } = "Platinum";

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long AccountNumber { get; set; }

        public PremiumPlusAccount(string firstName, string lastName, long accountNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AccountNumber = accountNumber;
        }

        public double Withdraw(long withdrawAmount)
        {
            if (withdrawAmount <= Balance + OverdraftLimit)
            {
                Balance -= withdrawAmount;
                Console.WriteLine($"{withdrawAmount} has been withdrawn.");
                Console.WriteLine($"Your new balance is {Balance}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Insufficient funds");
                Console.WriteLine($"You requested to withdraw {withdrawAmount} but your available balance is {Balance + OverdraftLimit}");
                Console.ReadKey();

                Console.WriteLine($"Your balance remains at {Balance}");

                Console.ReadKey();
            }
            return Balance;
        }

        public double Deposit(long depositAmount)
        {
            Balance += depositAmount;
            Console.WriteLine($"{depositAmount} has been deposited to account no: {AccountNumber}");

            Console.WriteLine($"Your new balance is {Balance}");
            Console.ReadKey();
            return Balance;
        }

        public double GetBalance()
        {
            Console.WriteLine($"Your current balance is {Balance}");
            Console.ReadKey();
            return Balance;
        }
    }
}
