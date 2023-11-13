namespace ATM_CaseStudy
{
    internal abstract class Transaction
    {
        private int accountNumber { get; }
        //private BankDatabase bankDatabase { get; }
        //private Screen screen { get; }

        public Transaction()
        {

        }

        public virtual void Execute()
        {

        }
    }
}
