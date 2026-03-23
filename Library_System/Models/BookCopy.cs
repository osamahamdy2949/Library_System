using Library_System.Contracts.Interfaces;
using Library_System.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class BookCopy : IDisplaiable , IBorrowable
    {

        public string CopyId { get; private set; }
        public string Condition { get; private set; }
        public CopyStatus Status { get; private set; }
        public Book Book { get; private set; }
        public BorrowTransaction? ActiveTransaction { get; private set; }
        public BookCopy(string copyId, Book copy, string condition = "Good")
        {
            CopyId = copyId;
            Condition = condition ;
            Book = copy;
            Status = CopyStatus.Available;
        }

        public bool IsAvailable() => Status == CopyStatus.Available;

        public void Borrow(Member member , int loanDays = 14)
        {
            if (Status != CopyStatus.Available)
                throw new InvalidOperationException($"Copy {CopyId} is not available (Status: {Status}).");

            Status = CopyStatus.Borrowed;
            ActiveTransaction = new BorrowTransaction(member ,this , loanDays);
            member.AddTransaction(ActiveTransaction);
        }

        public decimal Return()
        {
            if (ActiveTransaction == null)
                throw new InvalidOperationException("No active transaction for this copy.");

            if (Status != CopyStatus.Borrowed)
                throw new InvalidOperationException($"Copy {CopyId} is not currently borrowed.");

            ActiveTransaction.MarkReturned(DateOnly.FromDateTime(DateTime.Today));
            decimal fine = ActiveTransaction.CalculateFine();
            Status = CopyStatus.Available;
            ActiveTransaction = null;

            return fine;
        }

        public string ToDisplayString()
        {
            string avail = IsAvailable() ? "Available" : $"{Status}";
            return $"Copy [{CopyId}] — {Book.Title} | Condition: {Condition} | {avail}";
        }
    }
}
