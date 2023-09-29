namespace Ex_1109
{
    internal class SavingsAcount : Account
    {
        private decimal interestRate;

        public SavingsAcount(decimal accountBalance, decimal interestRate) : base(accountBalance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            set
            {
                interestRate = value / 100;
            }
        }

        public decimal CalculateInterest() => InterestRate * AccountBalance;
    }
}
