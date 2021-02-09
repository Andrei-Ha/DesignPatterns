using System;
using System.Collections.Generic;
using System.Text;


namespace Iterator
{
    /*
    class Numbers
    {
        private int[] _nums;
        public Numbers(int[] nums)
        {
            _nums = nums;
        }
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in _nums)
                yield return i + 2;
        }
    }*/
    class Book
    {
        public string Name { get; set; }
    }
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
    class Library: IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
                new Book {Name="Война и мир"},
                new Book {Name = "Отцы и дети"},
                new Book {Name = "Вишневый сад"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }
        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
    class LibraryNumerator: IBookIterator
    {
        IBookNumerable _aggreagate;
        int index = 0;
        public LibraryNumerator(IBookNumerable l)
        {
            _aggreagate = l;
        }
        public bool HasNext()
        {
            return index < _aggreagate.Count;
        }
        public Book Next()
        {
            return _aggreagate[index++];
        }
    }
    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while(iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
