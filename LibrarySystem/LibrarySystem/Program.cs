namespace LibrarySystem;
class Program
{
    static void Main(string[] args)
    {
        var shouldExit = false;
        var library = new Library(
        [
            new Book("book1", "author1", "1", 1),
            new Book("book2", "author2", "2", 2),
            new Book("book3", "author3", "3", 3),
            new Book("book4", "author4", "4", 4),
            new Book("book5", "author5", "5", 5),
            new Book("book6", "author6", "6", 6),
        ]);
        
        while (!shouldExit)
        {
            ShowMenu();
            string input = Console.ReadLine()!;

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Du skal indtaste et heltal");
                continue;
            }

            switch (result)
            {
                case 1:
                    ShowAllBooks(library);
                    break;
                case 2:
                    SearchBook(library);
                    break;
                case 3:
                    BorrowBook(library);
                    break;
                case 4:
                    ReturnBook(library);
                    break;
                case 5:
                    shouldExit = true;
                    break;
                default:
                    Console.WriteLine("Det er ikke en gyldig valgmulighed");
                    break;
            }
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("Vaelg en handling:");
        Console.WriteLine("1. Vis alle boeger");
        Console.WriteLine("2. Søg efter en bog");
        Console.WriteLine("3. Laan en bog");
        Console.WriteLine("4. Aflever en bog");
        Console.WriteLine("5. Afslut");
    }

    private static void ShowAllBooks(Library library)
    {
        foreach (var book in library.BookCollection)
        {
            Console.WriteLine(book);
        }
    }

    private static void SearchBook(Library library)
    {
        Console.WriteLine("Indtast et soege argument");
        var search = Console.ReadLine()!;
        var result = library.BookCollection.Where(book => book.Title.Contains(search));

        foreach (var book in result)
        {
            Console.WriteLine(book);
        }
    }

    private static void BorrowBook(Library library)
    {
        Console.WriteLine("Indtast ISBN på den bog du ønsker at laane");
        var isbn = Console.ReadLine()!;
        
        // Find the first book that matches isbn and is not already on loan
        var book = library.BookCollection.FirstOrDefault(book => book.Isbn == isbn);

        if (book == null)
        {
            Console.WriteLine("Vi har ikke den bog du bad om");
            return;
        }
        
        if (book.IsOnLoan)
        {
            Console.WriteLine($"{book.Title} er allerede udlånt");
            return;
        }
        
        book.CheckOut();
        Console.WriteLine($"Du har laant {book.Title}");
    }

    private static void ReturnBook(Library library)
    {
        Console.WriteLine("Indtast ISBN på den bog du ønsker at aflevere");
        var isbn = Console.ReadLine();
        
        var book = library.BookCollection.FirstOrDefault(book => book.Isbn == isbn);

        if (book == null)
        {
            Console.WriteLine("Den bog du prøver at afleverer tilhører ikke os");
            return;
        }

        if (!book.IsOnLoan)
        {
            Console.WriteLine($"{book.Title} er ikke udlånt");
            return;
        }
        
        book.Return();
        Console.WriteLine($"Du har afleveret {book.Title}");
    }
}