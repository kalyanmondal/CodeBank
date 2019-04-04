namespace StructuralPatterns.Facade
{
    public class LoanProcessor
    {
        private Bank bank;
        private Loan loan;
        private Credit credit;

        public LoanProcessor()
        {
            bank = new Bank();
            loan = new Loan();
            credit = new Credit();
        }

        public bool ProcessLoanHavingSavingsBankAccount(Customer customer)
        {
            bool hasBankApproval;
            bool hasLoanDeptApproval = loan.HasNoBadLoans(customer);
            bool hasCreditDeptApproval = credit.HasGoodCredit(customer);
            
            if (customer.IsPrimeCustomer)
            {
                hasBankApproval = true;
            }
            else
            {
                hasBankApproval = bank.HasSufficientSavings(customer);
            }

            return hasBankApproval && hasLoanDeptApproval && hasCreditDeptApproval;
        }

        public bool ProcessLoanNotHavingSavingsBankAccount(Customer customer)
        {
            bool hasBankApproval = bank.HasSufficientSavings(customer);
            bool hasLoanDeptApproval = loan.HasNoBadLoans(customer); 
            bool hasCreditDeptApproval = credit.HasGoodCredit(customer);

            return hasBankApproval && hasLoanDeptApproval && hasCreditDeptApproval;
        }
    }
}
