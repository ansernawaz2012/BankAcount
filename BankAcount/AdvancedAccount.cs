using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class AdvancedAccount:IBankAccount
    {
        public string AccountType { get; } = "Advanced";
        public double Balance { get; set; } = 0;
        public int OverdraftLimit { get; } = 2000;
        public string CCType { get; } = "Silver";

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long AccountNumber { get; set; }

        public AdvancedAccount(string firstName, string lastName, long accountNumber)
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
