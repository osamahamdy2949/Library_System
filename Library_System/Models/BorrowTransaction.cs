using Library_System.Contracts.Interfaces;

namespace Library_System.Models
{
    public class BorrowTransaction : IDisplaiable
    {
        private static int _counter = 1000;
        private const decimal _finePerDay = 10m;
        private const string DateFormat = "dd/MM/yyyy";

        public int TransactionId { get; private set; }
        public Member Member { get; private set; } = null!;
        public BookCopy BookCopy { get; private set; } = null!;
        public DateOnly BorrowDate { get; private set; }
        public DateOnly DueDate { get; private set; }
        public DateOnly? ReturnDate { get; private set; }

        public BorrowTransaction(Member member, BookCopy bookCopy , int loanDays = 14)
        {
            TransactionId = ++_counter;
            Member = member;
            BookCopy = bookCopy;
            BorrowDate = DateOnly.FromDateTime(DateTime.Today);
            DueDate = DateOnly.FromDateTime(DateTime.Today.AddDays(loanDays));
            ReturnDate = null;
        }

        public bool IsReturned() => ReturnDate.HasValue;
        public void MarkReturned(DateOnly returnDate)
        {
            ReturnDate = returnDate;
        }

        public decimal CalculateFine()
        {
            DateOnly effictive = ReturnDate ?? DateOnly.FromDateTime(DateTime.Today);
            int overDueDate = effictive.DayNumber - DueDate.DayNumber;

            return overDueDate > 0 ? overDueDate * _finePerDay : 0;
        }
        public decimal CalculateFine(DateOnly returnDate)
        {
            int overDueDate = returnDate.DayNumber - DueDate.DayNumber;
            
            return overDueDate > 0 ? overDueDate * _finePerDay : 0;
        }
        public string ToDisplayString()
        {
            string status = ReturnDate.HasValue ? "Returned" : "Active";
            decimal fine = CalculateFine();
            string returnInfo = ReturnDate.HasValue ? ReturnDate.Value.ToString(DateFormat) : "Not returned yet";
            string fineLine = fine > 0 ? $"{fine:F2} EGP" : "None";

            return $@"── Transaction #{TransactionId} ──────────────
Book      : {BookCopy.Book.Title}
Copy ID   : {BookCopy.CopyId}
Borrowed  : {BorrowDate.ToString(DateFormat)}
Due       : {DueDate.ToString(DateFormat)}
Returned  : {returnInfo}
Status    : {status}
Fine      : {fineLine}";
        }
    }
}