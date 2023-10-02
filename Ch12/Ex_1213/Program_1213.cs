using Ex_1109;

namespace Ex_1213
{
    internal class Program_1213
    {
        static void Main(string[] args)
        {

            var accounts = new List<Account>() {
            new SavingsAcount(500, 2),
            new SavingsAcount(100, 5),
            new SavingsAcount(1000, 5),
            new CheckingAccount(500, 10),
            new CheckingAccount(1000, 50),
            new CheckingAccount(100, 5)};

            Console.WriteLine("Accounts processed polymorphically");

            foreach (var account in accounts)
            {
                Console.WriteLine($"\nAccount balace: {account.AccountBalance}");
                if (account is SavingsAcount)
                {
                    var savingAccount = (SavingsAcount)account;
                    decimal interest = savingAccount.CalculateInterest();
                    Console.WriteLine($"Added {interest} to account due to interest");
                    savingAccount.Credit(interest);
                    Console.WriteLine($"New Account balance: {account.AccountBalance}");
                }
                Console.Write("Amount to Credit: ");
                decimal credit = decimal.Parse(Console.ReadLine());
                account.Credit(credit);
                Console.WriteLine($"New Account balance: {account.AccountBalance}");
                Console.Write("Amount to debit: ");
                decimal debit = decimal.Parse(Console.ReadLine());
                account.Debit(debit);
                Console.WriteLine($"New Account balance: {account.AccountBalance}");
            }

        }
    }
}