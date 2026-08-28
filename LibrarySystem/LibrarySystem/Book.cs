using System;

namespace LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private int _publicationYear;
        private bool _isOnLoan;

        public Book(string title, string author, string isbn, int publicationYear)
        {
            Title = title;
            Author = author;
            _isbn = isbn;
            _publicationYear = publicationYear;
            _isOnLoan = false;
        }

        public Book(string title, string author)
            : this(title, author, "ukendt", 0)
        {
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Titel må ikke være tom.", nameof(value));
                }
                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Forfatter må ikke være tom.", nameof(value));
                }
                _author = value;
            }
        }

        public string Isbn => _isbn;

        public int PublicationYear => _publicationYear;

        public bool IsOnLoan => _isOnLoan;

        public void CheckOut()
        {
            if (_isOnLoan)
            {
                throw new InvalidOperationException(
                    $"Bogen '{_title}' er allerede udlånt og kan ikke lånes igen, før den er afleveret.");
            }

            _isOnLoan = true;
        }

        public void Return()
        {
            _isOnLoan = false;
        }

        public override string ToString()
        {
            string status = _isOnLoan ? "udlånt" : "på hylden";
            return $"{_title} af {_author} ({_publicationYear}) - {status}";
        }
    }
}
