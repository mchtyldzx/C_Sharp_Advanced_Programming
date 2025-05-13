using System;
using DocumentManagement.Exceptions;

namespace DocumentManagement
{
    public class Book : Document
    {
        public string Author { get; set; }

        public Book() : base()
        {
            // Default constructor
        }

        public Book(string isbn, string title, int publicationYear, int pageCount, string author)
            : base(isbn, title, publicationYear, pageCount)
        {
            if (publicationYear < 1440) // Gutenberg's printing press was invented around 1440
            {
                throw new PrintingNotInventedYearException("Book publication year cannot be before the invention of printing (1440)");
            }
            Author = author;
        }

        public override string Print()
        {
            return $"Printing book: {Title} by {Author}";
        }

        public override string ToString()
        {
            return $"Book - {base.ToString()}, Author: {Author}";
        }
    }
} 
