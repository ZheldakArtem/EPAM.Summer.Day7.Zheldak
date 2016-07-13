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
        [Test,TestCaseSource(nameof(BooksSortData))]
        public void Book_Sort_By_Criterion(Book[] arrBooks, Criterion criterion, Book[] expectedBooks)
        {
            SortBooks(arrBooks, criterion);
            CollectionAssert.AreEqual(arrBooks, expectedBooks);
        }


        public static readonly Book[] BooksData = {
            new Book("CCC","AAA","BBB",13),
            new Book("AAA","BBB","CCC",1),
            new Book("BBB","CCC","AAA",14)
        };

        public static readonly Book[] ExpectedBooksByAuthor = {
            new Book("AAA", "BBB", "CCC", 1),
            new Book("BBB", "CCC", "AAA", 14),
            new Book("CCC", "AAA", "BBB", 13)
        };

        public static readonly Book[] ExpectedBooksByTitle = {
            new Book("CCC", "AAA", "BBB", 13),
            new Book("AAA", "BBB", "CCC", 1),
            new Book("BBB", "CCC", "AAA", 14)
        };

        public static Book[] ExpectedBooksByYear { get; } = {
            new Book("AAA", "BBB", "CCC", 1),
            new Book("CCC", "AAA", "BBB", 13),
            new Book("BBB", "CCC", "AAA", 14)
        };

        public static readonly object[] BooksSortData  = {
            new object[] {BooksData, Criterion.Year, ExpectedBooksByYear},
            new object[] {BooksData, Criterion.Title, ExpectedBooksByTitle},
            new object[] {BooksData, Criterion.Author, ExpectedBooksByAuthor}
            
        };
    }
}
