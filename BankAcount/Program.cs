using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount basicAccount = new BasicAccount("Anser", "Nawaz", 11111111);
            IBankAccount advancedAccount = new AdvancedAccount("Warren", "Pitterson", 22222222);
            IBankAccount premiumAccount = new PremiumAccount("Liam", "Wheeler", 33333333);
            IBankAccount premiumPlusAccount = new PremiumPlusAccount("Eugenie", "FDR", 44444444);

            Bank bank = new Bank();
            bank.AccountSummary(basicAccount);
                       
            bank.AccountSummary(advancedAccount);

            bank.AccountSummary(premiumAccount);

            bank.AccountSummary(premiumPlusAccount);
            
            
            // Console.ReadKey();
        }
    }
}
