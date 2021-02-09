using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IEnumerable actors = new ArrayList(); //new string[] { "first", "second", "third" };
            IEnumerator perechislitel = actors.GetEnumerator();

            Numbers numbers = new Numbers(new int[] { 2, 4, 5, 7, 9, 11 });
            foreach(int i in numbers)
                Console.WriteLine(i);
            Console.ReadKey();
            */
            Library MyLibrary = new Library();
            Reader MyReader = new Reader();
            MyReader.SeeBooks(MyLibrary);
            Console.Read();
        }
    }
}
