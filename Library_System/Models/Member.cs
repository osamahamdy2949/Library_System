using Library_System.Contracts;
using Library_System.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class Member : LibraryUser , IDisplaiable
    {
        private static int _counter = 1;

        public string MembershipId { get; private set; }
        public string? Email { get; private set; }
        public DateOnly? DateOfBirth { get; private set; }
        public DateOnly MembershipDate { get; private set; }

        private readonly List<BorrowTransaction> _transactions = new();
        public IReadOnlyList<BorrowTransaction> Transactions => _transactions;

        public Member(string name, DateOnly? dob, string? email , string phone, DateOnly memberShipDate) : base(name , phone)
        {
            MembershipId = $"MEM-{_counter++:D3}";
            Email = email;
            DateOfBirth = dob;
            MembershipDate = memberShipDate;
        }
        public Member(string name, string phone) : this(name , null , null , phone , DateOnly.FromDateTime(DateTime.Today))
        {
        }

        public void AddTransaction(BorrowTransaction tran) => _transactions.Add(tran);

        public string GetHistoryDisplayString()
        {
            if (Transactions.Count == 0)
                return "  No transactions found";

            var sb = new StringBuilder();
            for (int i = 0; i < Transactions.Count; i++)
            {
                sb.AppendLine(Transactions[i].ToDisplayString());
            }
            return sb.ToString();
        }

        public override string ToDisplayString() => $@"ID      : {MembershipId}
Name    : {Name}
Phone   : {Phone}
Email   : {Email ?? "N/A"}
Joined  : {MembershipDate:dd/MM/yyyy}
Borrows : {Transactions.Count}";
    }
}
