using System;

namespace Lesson02.Library
{
    public class Borrower
    {
        private const int MaxNumberOfBooksLoaned = 5;

        private string _name;
        private string _borrowerNumber;
        private int _numberOfBooksLoaned;

        public Borrower(string name, string borrowerNumber)
        {
            this.Name = name;
            this.BorrowerNumber = borrowerNumber;
            this.NumberOfBooksLoaned = 0;
        }
        
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Navn må ikke være tomt.", nameof(value));
                }
                _name = value;
            }
        }

        public string BorrowerNumber
        {
            get { return _borrowerNumber; }
            init { _borrowerNumber = value; }
        }

        public int NumberOfBooksLoaned
        {
            get { return _numberOfBooksLoaned; }
            private set { _numberOfBooksLoaned = value; }
        }

        public void BorrowBook()
        {
            if (NumberOfBooksLoaned >= MaxNumberOfBooksLoaned)
            {
                throw new InvalidOperationException(
                    $"{Name} har allerede lånt det maksimale antal bøger ({MaxNumberOfBooksLoaned}).");
            }

            NumberOfBooksLoaned++;
        }

        public void ReturnBook()
        {
            if (NumberOfBooksLoaned > 0)
            {
                NumberOfBooksLoaned--;
            }
        }

        public override string ToString()
        {
            return $"{Name} (lånernr. {BorrowerNumber}) - {NumberOfBooksLoaned} bog(er) lånt";
        }
    }
}
