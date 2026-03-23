using Library_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Contracts.Interfaces
{
    public interface IBorrowable
    {
        void Borrow(Member member, int loanDays = 14);
        decimal Return();
        bool IsAvailable();
    }
}
