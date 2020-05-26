using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Comparable_Book
{
   
 class Library : IEnumerable<Book>
        {
            private SortedSet<Book> books;

      

            public Library(params Book[] books)
            {
                this.books = new SortedSet<Book>(books);
            


            }


 IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)books).GetEnumerator();
            }

            public IEnumerator<Book> GetEnumerator()
            {
                return new LibraryIterator(books);

            }


            public class LibraryIterator : IEnumerator<Book>
            {

                private readonly List<Book> books;
                private int currentIndex;
                public LibraryIterator(IEnumerable<Book> books)
                {
                    this.Reset();
                    this.books = new List<Book>(books);
                }

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public bool MoveNext()
                {
                    return ++this.currentIndex < this.books.Count;
                }
                public void Reset()
                {
                    this.currentIndex = -1;
                }

                public void Dispose()
                {
                }

                public Book Current
                {
                    get
                    {
                        return this.books[this.currentIndex];
                    }
                }

                object IEnumerator.Current => this.Current;
            }
        }
    }

