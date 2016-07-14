using System;
using System.Collections;
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
        [Test, TestCaseSource(nameof(CaseForSortBookВifferentTypes))]
        public void Book_Sort_By_Criterion(object[] arrBooks, IComparer comparer, object[] expectedBooks)
        {

            Array.Sort(arrBooks, comparer);
            CollectionAssert.AreEqual(arrBooks, expectedBooks);
        }

        public static IEnumerable CaseForSortBookВifferentTypes
        {
            get
            {
                yield return new TestCaseData(new object[]
                {
                 new Book("CCC","AAA","BBB",13,1000),
                 null,
                 new Book("AAA","BBB","CCC",1,1003),
                 new Book("BBB","CCC","AAA",14,123)
                },
                 new SortBookAuthor(),
                 new object[]
                 {
                 new Book("AAA", "BBB", "CCC", 1,1003),
                 new Book("BBB", "CCC", "AAA", 14,123),
                 new Book("CCC", "AAA", "BBB", 13,1000),
                 null
                });
                yield return new TestCaseData(new object[]
                {
                 new Book("CCC","AAA","BBB",13,1000),
                 null,
                 new Book("AAA","BBB","CCC",1,1003),
                 new Book("BBB","CCC","AAA",14,123)
                }, new SortBookTitle(), new object[]
                {
                 new Book("CCC", "AAA", "BBB", 13,1000),
                 new Book("AAA", "BBB", "CCC", 1,1003),
                 new Book("BBB", "CCC", "AAA", 14,123),
                 null
                 });
                yield return new TestCaseData(new object[]
                {
                 new Book("CCC","AAA","BBB",13,1000),
                 null,
                 new Book("AAA","BBB","CCC",1,1003),
                 new Book("BBB","CCC","AAA",14,123)
                },
                new SortBookPublication(), new object[]
                {
                new Book("AAA", "BBB", "CCC", 1,1003),
                new Book("CCC", "AAA", "BBB", 13,1000),
                new Book("BBB", "CCC", "AAA", 14,123),
                null
             });
            }
        }

    }
}
