using Library_System.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    public class Book : IDisplaiable
    {

        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string AuthorName { get; private set; }
        public string Category {  get; private set; }
        public int PublicationYear { get; private set; }

        public Book(string iSBN, string title, string authorName, string category, int publicationYear)
        {
            ISBN = iSBN;
            Title = title;
            AuthorName = authorName;
            Category = category;
            PublicationYear = publicationYear;
        }
        public Book(string iSBN, string title) : this(iSBN, title, "Unknown", "General", 0)
        {
            ISBN = iSBN;
            Title = title;
        }

        public string ToDisplayString() => $"[{ISBN}] \"{Title}\" by {AuthorName} ({PublicationYear}) — {Category}";
    }
}
