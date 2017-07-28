using System;
using System.Collections.Generic;

public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors;
    }

    public string Title { get; protected set; }

    public int Year { get; protected set; }

    public IReadOnlyList<string> Authors { get; protected set; }

    public int CompareTo(Book other)
    {
        var yearsDiff = this.Year.CompareTo(other.Year);

        if (yearsDiff != 0)
        {
            return yearsDiff;
        }

        return this.Title.CompareTo(other.Title);
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}