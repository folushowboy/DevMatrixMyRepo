using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class Books
    {
        public int ISBN {  get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public string AvailabilityStatus { get; set; }

        public static void AddNewBooks(List<Books> books)
        {
            Console.WriteLine("Add new books\n");
            books.Add(new Books { Title = "The Midnight Library", ISBN = 1, Author = "Matt Haig", YearPublished = 2020, AvailabilityStatus = "Available" });
            books.Add(new Books { Title = "Atomic Habits", ISBN = 2, Author = "James Clear", YearPublished = 2002, AvailabilityStatus = "Available" });
            books.Add(new Books { Title = "Pride and Prejudice", ISBN = 4 , Author = "Jane Austen", YearPublished = 2015, AvailabilityStatus = "Available" });
            books.Add(new Books { Title = "The Alchemist", ISBN = 3, Author = "Matt Haig", YearPublished = 1813, AvailabilityStatus = "Available" });   

            foreach(var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Status: {book.AvailabilityStatus}");
            }
        }

        public static void ViewAvailableBooks(List<Books> books)
        {
            Console.WriteLine("\nAvailable books\n");
            foreach (Books book in books)
            {
                if (book.AvailabilityStatus != "Borrowed")
                {
                    Console.WriteLine($"The available Books: {book.Title}, {book.Author}, {book.AvailabilityStatus}");
                }
            }
        }


        public static void SearchForABook(List<Books> books)
        {

            while (true)
            {
                Console.WriteLine("\nSearch for a book");
                Console.Write("Enter title or author: ");

                string choice = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(choice))
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                    continue; 
                }

                bool found = false;

                foreach (Books book in books)
                {
                    if ((book.Author.ToLower().Contains(choice) || book.Title.ToLower().Contains(choice)))
                    {
                        found = true;
                        if (book.AvailabilityStatus == "Available")
                        {
                            Console.WriteLine($"Book Found: {book.Title}, {book.Author}, {book.AvailabilityStatus}");
                        }
                        else
                        {
                            Console.WriteLine($"Book is unavailable. {book.Title} has already been borrowed..");
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No book matches your search.");
                    continue;
                }
                break; 
            }  
        }
    }
}

