using Library_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class Librarian : LibraryUser
    {

        public string LibrarianID { get; private set; } = null!;
        public decimal Salary { get; private set; }
        public DateOnly HireDate { get; private set; }

        public Librarian(string librarianID, string name, string phone, decimal salary, DateOnly hiredate) : base (name , phone)
        {
            LibrarianID = librarianID;
            Salary = salary;
            HireDate = hiredate;
        }

        public override string ToDisplayString()
        {
            return $@"ID      : {LibrarianID}
Name    : {Name}
Phone   : {Phone}
Salary  : {Salary:C}
Hired   : {HireDate:dd/MM/yyyy}";
        }
    }
}
