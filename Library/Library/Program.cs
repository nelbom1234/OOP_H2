using System;

namespace Lesson02.Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Instantiering af objekter ---");

            Book book1 = new Book("1984", "George Orwell", "9788711539329", 1949);

            Book book2 = new Book("Fahrenheit 451", "Ray Bradbury", "9780345342966", 1953);

            Book book3 = new Book("Kladdehæfte om løs kobling", "Ukendt Forfatter");

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);

            Borrower borrower1 = new Borrower("Amina Hansen", "L-1001");
            Borrower borrower2 = new Borrower("Mikkel Poulsen", "L-1002");

            Console.WriteLine();
            Console.WriteLine("--- Udlån ---");

            book1.CheckOut();
            borrower1.BorrowBook();
            Console.WriteLine($"{borrower1.Name} har nu lånt: {book1}");

            try
            {
                book1.CheckOut();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Fejl fanget: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("--- Aflevering ---");

            book1.Return();
            borrower1.ReturnBook();
            Console.WriteLine($"{borrower1.Name} har nu lånt: {borrower1.NumberOfBooksLoaned} bog(er)");
            Console.WriteLine(book1);

            Console.WriteLine();
            Console.WriteLine("--- Forsøg på ugyldig oprettelse ---");
            try
            {
                Book invalidBook = new Book("", "En Forfatter");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Fejl fanget: {ex.Message}");
            }
        }
    }
}
