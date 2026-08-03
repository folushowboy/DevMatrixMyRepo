// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DevMatrixMyRepo;

List<Books> listOfBooks = new List<Books>();
listOfBooks.Add(new Books { Title = "The Da Vinci Code", ISBN = 5, Author = "Dan Brown", YearPublished = 2003, AvailabilityStatus = Avalaibility.Available });
listOfBooks.Add(new Books { Title = "To Kill a Mockingbird", ISBN = 4, Author = "Harper Lee", YearPublished = 1960, AvailabilityStatus = Avalaibility.Available });
listOfBooks.Add(new Books { Title = "1984", ISBN = 2, Author = "George Orwell", YearPublished = 1949, AvailabilityStatus = Avalaibility.Available });
listOfBooks.Add(new Books { Title = "The Hobbit", ISBN = 3, Author = "J.R.R. Tolkien", YearPublished = 1937, AvailabilityStatus = Avalaibility.Available });
listOfBooks.Add(new Books { Title = "The Silent Patient", ISBN = 1, Author = "Alex Michaelides", YearPublished = 2019, AvailabilityStatus = Avalaibility.Available });

List<Borrowers> borrowers = new List<Borrowers>();
borrowers.Add(new Borrowers { BorrowerID = 1, FullName = "Adedeji Emma", PhoneNumber = 09077867867, BorrowLimit = "2days" });
borrowers.Add(new Borrowers { BorrowerID = 2, FullName = "Odusina Paul", PhoneNumber = 09047382959, BorrowLimit = "1days" });
borrowers.Add(new Borrowers { BorrowerID = 3, FullName = "Nmerole John", PhoneNumber = 08076434578, BorrowLimit = "3days" });
borrowers.Add(new Borrowers { BorrowerID = 4, FullName = "Anjola Eunice", PhoneNumber = 0906464747, BorrowLimit = "5days" });
borrowers.Add(new Borrowers { BorrowerID = 5, FullName = "Enny Joy", PhoneNumber = 07066548392, BorrowLimit = "2days" });

List<Books> borrowedBooks = new List<Books>();


Books.ViewAvailableBooks(listOfBooks);
Books.AddNewBooks(listOfBooks);
Books.ViewAvailableBooks(listOfBooks);
Books.SearchForABook(listOfBooks);
BorrowABook(borrowers, listOfBooks);
Books.ViewAvailableBooks(listOfBooks);
ReturnABook(borrowers, borrowedBooks, listOfBooks);
Books.ViewAvailableBooks(listOfBooks);
Borrowers.ViewBorrowedBooks(borrowedBooks);


void BorrowABook(List<Borrowers> borrows, List<Books> books)
{
    Console.WriteLine("\nEnter Title to borrow book");
    string borrowMore = "Y";
    while (borrowMore == "Y")
    {
        Console.WriteLine("\nBorrow a book");
        Console.Write("Enter title or author: ");

        string choice = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(choice))
        {
            Console.WriteLine("Invalid input. Please try again.\n");
            continue;
        }
        Books bookToBorrow = null;
        bool found = false;
        //bookToBorrow.AvailabilityStatus = Avalaibility.Borrowed;

        foreach (Books bk in books)
        {
            if ((bk.Author.ToLower().Contains(choice) || bk.Title.ToLower().Contains(choice)))
            {
                found = true;
                bookToBorrow = bk;

                var BorrowBook = from book in books
                                 where book.ISBN == bk.ISBN
                                 join borrow in borrows on book.ISBN equals borrow.BorrowerID into bookBorrow
                                 from borrow in bookBorrow.DefaultIfEmpty()
                                 select new
                                 {
                                     book.Title,
                                     borrow.FullName,
                                 };
                
                foreach (var BB in BorrowBook)
                {
                    Console.WriteLine($"{BB.Title} has been borrowed by {BB.FullName}");
                }
            }
            
        }
        if (!found)
        {
            Console.WriteLine("No book matches your search.");
            continue;
        }
        if (bookToBorrow != null)
        {
            borrowedBooks.Add(bookToBorrow);
            books.Remove(bookToBorrow);
        }
        
        Console.WriteLine("Do you want to borrow another book? (Y/N)");
        borrowMore = Console.ReadLine().ToUpper();
        //break;
        Console.WriteLine($"Borrowed Books Count: {borrowedBooks.Count}");

    }
}


void ReturnABook(List<Borrowers> returned, List<Books> borrowedBooks, List<Books> books)
{
    Console.WriteLine("\nEnter Title to borrow book");
    string borrowMore = "Y";
    while (borrowMore == "Y")
    {
        Console.WriteLine("\nReturn a book");
        Console.Write("Enter title or author: ");

        string choice = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(choice))
        {
            Console.WriteLine("Invalid input. Please try again.\n");
            continue;
        }
        Books bookToReturn = null;
        bool found = false;

        foreach (Books bk in borrowedBooks)
        {
            if ((bk.Author.ToLower().Contains(choice) || bk.Title.ToLower().Contains(choice)))
            {
                found = true;
                bookToReturn = bk;

                var ReturnBook = from book in borrowedBooks
                                 where book.ISBN == bk.ISBN
                                 join returns in returned on book.ISBN equals returns.BorrowerID into bookReturn
                                 from returns in bookReturn.DefaultIfEmpty()
                                 select new
                                 {
                                     book.Title,
                                     returns.FullName,
                                 };

                foreach (var BB in ReturnBook)
                {
                    Console.WriteLine($"{BB.Title} has been return by {BB.FullName}");
                }
            }

        }
        if (!found)
        {
            Console.WriteLine("No book matches your search.");
            continue;
        }
        
        if (bookToReturn != null)
        {
            borrowedBooks.Remove(bookToReturn);
            books.Add(bookToReturn);
        }
        Console.WriteLine("Do you want to borrow another book? (Y/N)");
        borrowMore = Console.ReadLine().ToUpper();
        //break;
    }
}