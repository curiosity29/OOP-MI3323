using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using static System.Console;
namespace Week5
{
    public class BookList
    {
        private ArrayList list = new ArrayList();
        public void AddBook()
        {
            Book book = new Book();
            book.Input();
            list.Add(book);
        }
        public void ShowList()
        {
            foreach (Book b in list)
            {
                b.Show();
                WriteLine();
            }
        }

        public void InputList()
        {
            int n;
            WriteLine("Amounts of books: ");
            n = int.Parse(ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
        public void Sort(IComparer comparer)
        {
            list.Sort(comparer);
        }

    }
}
