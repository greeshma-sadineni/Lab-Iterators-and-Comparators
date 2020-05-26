using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable_Book
{
    class Book:IComparable<Book>
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
        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;

        }
        public override string ToString()
        {
            return $"{ this.Title}-{this.Year}";
        }

    }
}
