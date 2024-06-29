using LibraryManagment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment
{
    public class LoanService
    {
        private readonly ILoan _loan;
        public LoanService(ILoan loan)
        {
            _loan = loan;
        }
        public void AddLoan(Loan loan)
        {
            _loan.AddLoan(loan);
        }
        public void UpdateLoan(Loan loan)
        {
            _loan.UpdateLoan(loan);
        }
        public void DeleteLoan(int id)
        {
            _loan.DeleteLoan(id);
        }
        public Loan GetLoanById(int id)
        {
            return _loan.GetLoanById(id);
        }
        public List<Loan> GetAllLoans()
        {
            return _loan.GetAllLoans();
        }
    }
}
