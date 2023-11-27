// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
// using 

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Another item");
            Play();
            Console.WriteLine("Last item");
            Book book = new Book("A Cowrie of Hope", "B Sinyangwe", 455);
            book.print();
        }


        static void Play()
        {
            Console.WriteLine("I am a fast player ");
        }
    }
}