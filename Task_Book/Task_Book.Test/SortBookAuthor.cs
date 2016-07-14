using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Book.Test
{
    /// <summary>
    ///It's a class which compare books by author
    /// </summary>
    public class SortBookAuthor : IComparer, IComparer<Book>
    {
        public int Compare(Book lhs, Book rhs) 
        {
            if (ReferenceEquals(rhs, null))
                return -1;
            if (ReferenceEquals(lhs, null))
                return 1;
            return ReferenceEquals(lhs, rhs) ? 0 : lhs.Author.CompareTo(rhs.Author);
        }

        public int Compare(object lhs, object rhs)
        {
            if (ReferenceEquals(rhs, null))
                return -1;
            if (ReferenceEquals(lhs, null))
                return 1;
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (!(rhs is Book))
                return -1;
            if (!(lhs is Book))
                return 1;
            return Compare((Book)lhs, (Book)rhs);
        }
    }
}
