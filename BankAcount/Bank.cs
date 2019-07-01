using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class Bank
    {
        //public Bank(IBankAccount bankAccount)
        //{
        //    //Console.WriteLine($"This account is a {basic.AccountType}");
        //    //Console.WriteLine($"The overdraft limit is {basic.OverdraftLimit}");
        //    //Console.WriteLine($"The credit card issued with this account is the {basic.CCType}");

        //    AccountSummary(bankAccount);

        //    //basic.GetBalance();
        //    //basic.Deposit(300);
        //    //basic.Withdraw(500);
        //    //basic.Withdraw(155);

        //}

        public void AccountSummary(IBankAccount bankAccount)
        {
            Console.WriteLine("Account Summary");
            Console.WriteLine($"The name of the account holder is: {bankAccount.FirstName} {bankAccount.LastName}");
            Console.WriteLine($"The type of the account is: {bankAccount.AccountType}");
            Console.WriteLine($"The account number is: {bankAccount.AccountNumber}");
            Console.WriteLine($"You have been issued a {bankAccount.CCType} credit card");
            Console.WriteLine($"The overdraft limit for this account is: {bankAccount.OverdraftLimit}");
            Console.WriteLine("---------------------------------------------------------------   ");
            Console.ReadKey();


        }

    }
}
