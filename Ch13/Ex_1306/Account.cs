namespace Ex_1306
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

    }
}
