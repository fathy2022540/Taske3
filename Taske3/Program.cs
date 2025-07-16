namespace Taske3
{
    public class Library
    {
        List<Book> Books;
        public Library()
        {
            Books = new List<Book>();
        }


        public bool AddBook(Book book)
        {
       
            Books.Add(book);
            return true;
                
        }
        public bool SearchBook(string name) 
        {
            

            for (int i = 0; i < Books.Count; i++) {
                if (Books[i].title.Contains(name))
                {
                     return true;
                }
                
            }
            return false;
  
        }
        public bool BorrowBook(string name)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].title.Contains(name) && Books[i].availability==true)
                {
                    Books[i].availability =false;
                    return true;
                }

            }
            return false;


        }
        public bool ReturnBook(string name)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].title.Contains(name) && Books[i].availability == false)
                {
                    Books[i].availability = true;
                    return true;
                }

            }
            return false;

        }



    }
    public class Book
    {
        public string title ;
        public string author ;
        public string ISBN ;
        public bool availability;

        public Book(string title, string author, string iSBN, bool availability=true)
        {
            this.title = title;
            this.author = author;
            ISBN = iSBN;
            this.availability = availability;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            Console.WriteLine("Searching and borrowing books...");
            Console.WriteLine(library.SearchBook("Gatsby"));
            Console.WriteLine(library.BorrowBook("1984"));
            Console.WriteLine(library.SearchBook("Gatsby"));

            Console.WriteLine(library.BorrowBook("Gatsby")); 
            Console.WriteLine(library.BorrowBook("1984")); 
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed




            Console.ReadLine();

        }
    }
}
