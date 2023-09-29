namespace Ex_1109
{
    internal class Program_1109
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Account Test");
            Account accountTest = new Account(50);
            Console.WriteLine($"Balance: {accountTest.AccountBalance}");
            Console.WriteLine($"Credit(50): {accountTest.Credit(50)} {accountTest.AccountBalance}");
            Console.WriteLine($"Debit(50): {accountTest.Debit(50)} {accountTest.AccountBalance}");
            Console.WriteLine($"Debit(55): {accountTest.Debit(55)} {accountTest.AccountBalance}");

            Console.WriteLine("\nSavingsAccount Test");
            SavingsAcount savingTest = new SavingsAcount(50, 5);
            Console.WriteLine($"Balance / InterestRate : {savingTest.AccountBalance}, {savingTest.InterestRate} ");
            Console.WriteLine($"CalculateInterest(): {savingTest.CalculateInterest()}");

            Console.WriteLine("\nCheckingAccount Test");
            CheckingAccount checkingTest = new CheckingAccount(50, 5);
            Console.WriteLine($"Balance / FeeAmount : {checkingTest.AccountBalance}, {checkingTest.FeeAmount} ");
            Console.WriteLine($"Credit(50): {checkingTest.Credit(50)} {checkingTest.AccountBalance}");
            Console.WriteLine($"Debit(50): {checkingTest.Debit(50)} {checkingTest.AccountBalance}");
            Console.WriteLine($"Debit(36): {checkingTest.Debit(36)} {checkingTest.AccountBalance}");



        }
    }
}