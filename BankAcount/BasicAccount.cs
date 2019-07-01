using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class BasicAccount:IBankAccount
    {
        public string AccountType { get; } = "Basic";
        public double Balance { get; set; } = 0;
        public int OverdraftLimit { get; } = 500;
        public string CCType { get; } = "Bronze";

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long AccountNumber { get; set; }

        public BasicAccount(string firstName, string lastName, long accountNumber)
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
                Console.WriteLine($"You requested to withdraw {withdrawAmount} but your balance is {Balance}");
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
