using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using static System.Console;
namespace Week5
{
    public interface IBook
    {
        //property
        public string Name { get; }
        public string Author { get; }
        public string Publisher { get; }
        public int Year { get; }
        public int ISBN { get; }
        //array
        string this[int index]
        {
            get;
            set;
        }
        //method
        public void Show(); // show informations of that book
    }
    public class Book : IBook, IComparable<Book>
    {
        //field
        private string _name;
        private string _author;
        private string _publisher;
        private int _year;
        private int _ISBN;
        //property
        public string Name { get => _name; }
        public string Author { get => _author; }
        public string Publisher { get => _publisher; }
        public int Year { get => _year; }
        public int ISBN { get => _ISBN; }

        //array
        private ArrayList chapters = new ArrayList();
        // uninitialized !
        private int Count;
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
                    return (string)chapters[index];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapters.Count)
                    chapters[index] = value;
                else if (index == chapters.Count)
                    chapters.Add(value);
                else throw new IndexOutOfRangeException();
            }
        }

        //method
        public void Input()
        {
            WriteLine("Name: "); _name = ReadLine();
            WriteLine("Author: "); _author = ReadLine();
            WriteLine("Publisher: "); _publisher = ReadLine();
            WriteLine("ISBN: "); _ISBN = int.Parse(ReadLine());
            WriteLine("Year: "); _year = int.Parse(ReadLine());
            WriteLine("Input chapters (finish with empty string):");
            string chapter;
            do
            {
                chapter = ReadLine();
                Count = 0;
                if (chapter != "")
                {
                    chapters.Add(chapter);
                    Count = Count + 1;
                }
            } while (chapter != "");

        }
        public int CompareTo(Book b)
        {
            return this.Name.CompareTo(b.Name);
        }

        public void Show()
        {
            WriteLine("---start book info---");
            WriteLine("Name: " + _name);
            WriteLine("Author: " + _author);
            WriteLine("Publisher: " + _publisher);
            WriteLine("Year: " + _year);
            WriteLine("ISBN: " + _ISBN);
            WriteLine("Chapter: ");
            for (int i = 0; i < chapters.Count; i++)
            {
                WriteLine("---------------");
                WriteLine("\t{0}: {1}", i + 1, chapters[i]);
            }
            WriteLine("---end book info-----");
        }

        //public static Comparison<Book> NameCompare = (a, b) => a.Name.CompareTo(b.Name);
        //public static Comparison<Book> AuthorCompare = (a, b) => a.Author.CompareTo(b.Author);
        //public static Comparison<Book> PublisherCompare = (a, b) => a.Publisher.CompareTo(b.Publisher);
        //public static Comparison<Book> YearCompare = (a, b) => a.Year.CompareTo(b.Year);
        //public static Comparison<Book> ISBNCompare = (a, b) => a._ISBN.CompareTo(b.ISBN);
    }
    public class NameComparer : IComparer
    {
        public int Compare(Object a, Object b)
        {
            return ((Book)a).Name.CompareTo(((Book)b).Name);
        }
    }
    public class AuthorComparer : IComparer
    {
        public int Compare(Object a, Object b)
        {
            return ((Book)a).Author.CompareTo(((Book)b).Author);
        }
    }
    public class PublisherComparer : IComparer
    {
        public int Compare(Object a, Object b)
        {
            return ((Book)a).Publisher.CompareTo(((Book)b).Publisher);
        }
    }
    public class YearComparer : IComparer
    {
        public int Compare(Object a, Object b)
        {
            return ((Book)a).Year.CompareTo(((Book)b).Year);
        }
    }
    public class ISBNComparer : IComparer
    {
        public int Compare(Object a, Object b)
        {
            return ((Book)a).ISBN.CompareTo(((Book)b).ISBN);
        }
    }
}    
