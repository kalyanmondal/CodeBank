namespace StructuralPatterns.Facade
{
    public class Customer
    {
        public Customer(string name, bool isPrimeCustomer, int loanAmount, int balanceAmount, bool hasBadLoan, bool hasGoodCredit)
        {
            this.Name = name;
            this.IsPrimeCustomer = isPrimeCustomer;
            this.LoanAmount = loanAmount;
            this.BalanceAmount = balanceAmount;
            this.HasBadLoan = hasBadLoan;
            this.HasGoodCredit = hasGoodCredit;
        }

        public string Name { get; set; }

        public bool IsPrimeCustomer { get; set; }

        public int LoanAmount { get; set; }

        public int BalanceAmount { get; set; }

        public bool HasBadLoan { get; set; }

        public bool HasGoodCredit { get; set; }
    }
}
