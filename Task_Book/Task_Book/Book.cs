using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Book
{
    public sealed class Book : IEquatable<Book>, IComparable<Book>
    {
        private int _yearPublication;
        private int _pages;
        public string Author { get; }
        public string Title { get; }
        public string Genre { get; }

        public int Pages
        {
            get { return _pages; }
            private set
            {
                if (value < 0) throw new ArgumentException();
                _pages = value;
            }
        }
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

        public Book(string author, string title, string genre, int publication, int pages)
        {
            this.Author = author;
            this.Title = title;
            this.Genre = genre;
            this.Publication = publication;
            this.Pages = pages;
        }

        public bool Equals(Book other)
        {
            return !ReferenceEquals(other, null) && PropertyValid(other);
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

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _yearPublication;
                hashCode = (hashCode * 397) ^ _pages;
                hashCode = (hashCode * 397) ^ (Author?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Title?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Genre?.GetHashCode() ?? 0);
                return hashCode;
            }
        }

        public int CompareTo(Book other)
        {
            if (ReferenceEquals(other, null))
                return -1;
            if (this.Pages == other.Pages)
                return 0;
            if (this.Pages > other.Pages)
                return 1;
            return -1;

        }

        private bool PropertyValid(Book other)
        {
            return (this.Author == other.Author && this.Title == other.Title && this.Genre == other.Genre &&
                    this.Publication == other.Publication && this.Pages == other.Pages);
        }

    }
}
