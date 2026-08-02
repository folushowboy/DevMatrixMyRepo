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



Books.AddNewBooks(listOfBooks);
Books.ViewAvailableBooks(listOfBooks);
Books.SearchForABook(listOfBooks);


static void BorrowABook(List<Borrowers> borrows, List<Books> books)
{
    Console.WriteLine("Enter Tilte to borrow book");
    string choice = Console.ReadLine();
    //var booksToBorrow = borrowbook.FirstOrDefault(x => x.);
    var BorrowBook = from book in books
                     join borrow in borrows on book.ISBN equals borrow.BorrowerID into bookBorrow
                     from borrow in bookBorrow.DefaultIfEmpty()
                     select new
                     {
                         book.Title,
                         borrow.FullName,
                         availability = book.AvailabilityStatus == Avalaibility.Available ? "Available" : "Borrowed"
                     };
    foreach (var BB in BorrowBook)
    {
        Console.WriteLine($"{BB.Title} has been borrowed by {BB.FullName}");
    }
}


