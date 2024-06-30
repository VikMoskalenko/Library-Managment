using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.classes;

namespace LibraryManagment.Interfaces
{
    public interface ILoan
    {
        void AddLoan(Loan loan);
        void UpdateLoan(Loan loan);
        void DeleteLoan(int id);
        Loan GetLoanById(int id);
        List<Loan> GetAllLoans();
    }
}
