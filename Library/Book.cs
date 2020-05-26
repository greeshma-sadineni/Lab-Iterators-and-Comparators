using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {

        public string Title;
        public int Year;

        public IReadOnlyList<string> Authors;

        public Book(string Title, int Year, params string[] Authors)
        {
            this.Title = Title;
            this.Year = Year;
            this.Authors = Authors;
        }
    }
}
