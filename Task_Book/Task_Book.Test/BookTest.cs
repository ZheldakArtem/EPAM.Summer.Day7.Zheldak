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


        public static Book[] BooksData { get; } = {
            new Book("CCC","AAA","BBB",13),
            new Book("AAA","BBB","CCC",1),
            new Book("BBB","CCC","AAA",14)
        };

        public static Book[] ExpectedBooksByAuthor { get; } = {
            new Book("AAA", "BBB", "CCC", 1),
            new Book("BBB", "CCC", "AAA", 14),
            new Book("CCC", "AAA", "BBB", 13)
        };

        public static Book[] ExpectedBooksByTitle { get; } = {
            new Book("CCC", "AAA", "BBB", 13),
            new Book("AAA", "BBB", "CCC", 1),
            new Book("BBB", "CCC", "AAA", 14)
        };

        public static Book[] ExpectedBooksByYear { get; } = {
            new Book("AAA", "BBB", "CCC", 1),
            new Book("CCC", "AAA", "BBB", 13),
            new Book("BBB", "CCC", "AAA", 14)
        };

        public static object[] BooksSortData { get; } = {
            new object[] {BooksData, Criterion.Author, ExpectedBooksByAuthor},
            new object[] {BooksData, Criterion.Title, ExpectedBooksByTitle},
            new object[] {BooksData, Criterion.Year, ExpectedBooksByYear},
        };
    }
}
