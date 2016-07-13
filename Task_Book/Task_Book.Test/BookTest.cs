using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Book;
using NUnit.Framework;
using static Task_Book.Book;

namespace Task_Book.Test
{
    public class BookTest
    {
        public void Book_Sort_With_Criterion(Book[] arrBooks, Book[] expectedBooks, Criterion criterion)
        {
            SortBooks(arrBooks, criterion);
            CollectionAssert.AreEqual(arrBooks, expectedBooks);
        }

       }
}
