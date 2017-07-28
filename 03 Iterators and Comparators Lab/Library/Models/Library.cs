using System;
using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> Books { get; set; }

    public Library(params Book[] books)
    {
        this.Books = new SortedSet<Book>(new BookComparator());

        foreach (var book in books)
        {
            this.Books.Add(book);
        }
    }

    public IEnumerator<Book> GetEnumerator() => new LibraryIterator(this.Books);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currentIndex;

        public LibraryIterator(SortedSet<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose() { }

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;
    }
}