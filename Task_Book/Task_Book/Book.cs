﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Book
{
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        private int _yearPublication;
        public string Author { get; }
        public string Title { get; }
        public string Genre { get; }
        public int Publication
        {
            get
            {
                return _yearPublication;
            }
            private set
            {
                if (value < 1)
                    throw new ArgumentException();
                _yearPublication = value;
            }
        }

        public Book(string author, string title, string genre, int publication)
        {
            this.Author = author;
            this.Title = title;
            this.Genre = genre;
            this.Publication = publication;
        }

        public bool Equals(Book other)
        {
            if (other == null)
                return false;
            if (this.Author == other.Author && this.Title == other.Title && this.Genre == other.Genre && this.Publication == other.Publication)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Equals((Book)obj);
        }

        public int CompareTo(Book other)
        {
            if (ReferenceEquals(this, other))
                return 0;
            if (ReferenceEquals(other, null))
                return -1;

            return CompareTo(other, Criterion.Title);
        }

        public int CompareTo(Book other, Criterion criterion = Criterion.Title)
        {
            int compare = 0;
            switch (criterion)
            {
                case Criterion.Title:
                    compare = this.Title.CompareTo(other.Title);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    this.Author.CompareTo(other.Author);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Genre.CompareTo(other.Genre);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Publication.CompareTo(other.Publication);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    break;
                case Criterion.Author:
                    compare = this.Author.CompareTo(other.Author);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Title.CompareTo(other.Title);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Genre.CompareTo(other.Genre);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Publication.CompareTo(other.Publication);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    break;
                case Criterion.Year:
                    compare = this.Publication.CompareTo(other.Publication);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    this.Author.CompareTo(other.Author);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Title.CompareTo(other.Title);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    compare = this.Genre.CompareTo(other.Genre);
                    if (compare != 0)
                    {
                        return compare;
                    }
                    break;
            }

            return this.Publication.CompareTo(other.Publication);
        }
        public override int GetHashCode()
        {
            int hash = Author.GetHashCode() + Title.GetHashCode() + Genre.GetHashCode() + Publication.GetHashCode();

            return hash;
        }

        public static void SortBooks(Book[] arrayBook, Criterion criterion = Criterion.Title)
        {
            if (ReferenceEquals(arrayBook, null))
                throw new ArgumentException();

            switch (criterion)
            {
                case Criterion.Author:
                    SortAuthor(arrayBook);
                    break;
                case Criterion.Title:
                    SortTitle(arrayBook);
                    break;
                case Criterion.Year:
                    SortYear(arrayBook);
                    break;
            }

        }

        private static void SortYear(Book[] arrBook)
        {
            for (int i = 0; i < arrBook.Length - 1; i++)
            {
                for (int j = 0; j < arrBook.Length - i - 1; j++)
                {
                    if (arrBook[j].CompareTo(arrBook[j + 1], Criterion.Year) == 1)
                    {
                        Swap(ref arrBook[j], ref arrBook[j + 1]);
                    }
                }
            }
        }

        private static void SortTitle(Book[] arrBook)
        {
            for (int i = 0; i < arrBook.Length - 1; i++)
            {
                for (int j = 0; j < arrBook.Length - i - 1; j++)
                {
                    if (arrBook[j].CompareTo(arrBook[j + 1], Criterion.Title) == 1)
                    {
                        Swap(ref arrBook[j], ref arrBook[j + 1]);
                    }
                }
            }
        }

        private static void SortAuthor(Book[] arrBook)
        {
            for (int i = 0; i < arrBook.Length-1; i++)
            {
                for (int j = 0; j < arrBook.Length - i - 1; j++)
                {
                    if (arrBook[j].CompareTo(arrBook[j + 1], Criterion.Author) == 1)
                    {
                        Swap(ref arrBook[j], ref arrBook[j + 1]);
                    }
                }
            }
        }
        private static void Swap(ref Book firstBook, ref Book secondBook)
        {
            var temp = firstBook;
            firstBook = secondBook;
            secondBook = temp;
        }
        public enum Criterion
        {
            Author,
            Title,
            Year
        }
    }
}
