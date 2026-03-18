using Library_System.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Contracts
{
    public abstract class LibraryUser : IDisplaiable
    {

        public string Name { get; protected set; }
        public string Phone { get; protected set; }

        protected LibraryUser(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public abstract string ToDisplayString();

    }
}
