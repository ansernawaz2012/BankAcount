using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public interface IBankAccount
    {
         string AccountType { get; }
         double Balance { get; set; }
         int OverdraftLimit { get; } 
         string CCType { get; }

         string FirstName { get; set; }

         string LastName { get; set; }

         long AccountNumber { get; set; }


        double Withdraw(long withdrawAmount);
        double Deposit(long depositAmount);
        double GetBalance();
    }
}
