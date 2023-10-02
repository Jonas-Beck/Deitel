namespace Ex_1109
{
    internal class CheckingAccount : Account
    {
        private decimal feeAmount;

        public CheckingAccount(decimal accountBalance, decimal feeAmount) : base(accountBalance)
        {
            FeeAmount = feeAmount;
        }

        public decimal FeeAmount
        {
            get
            {
                return feeAmount;
            }
            set
            {
                feeAmount = value;
            }
        }
        public override bool Credit(decimal balance)
        {
            if (balance - FeeAmount < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot credit amount smaller then transaction fee");
            }
            return base.Credit(balance - FeeAmount);
        }
        public override bool Debit(decimal balance)
        {
            return base.Debit(balance + FeeAmount);
        }
    }
}
