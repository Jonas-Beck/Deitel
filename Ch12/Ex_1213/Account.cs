namespace Ex_1109
{
    internal class Account
    {
        private decimal accountBalance;

        public Account(decimal accountBalance)
        {
            AccountBalance = accountBalance;
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(AccountBalance)} must be >= 0");
                }
                accountBalance = value;
            }
        }

        public virtual bool Credit(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot Credit negative numbers");
            }
            AccountBalance += balance;
            return true;
        }
        public virtual bool Debit(decimal balance)
        {
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot Debit negative numbers");
            }
            try
            {
                AccountBalance -= balance;
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            }
        }

    }
}
