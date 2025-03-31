using System;

namespace DocumentManagement
{
    public abstract class Document
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int PageCount { get; set; }

        protected Document()
        {
            // Default constructor
        }

        protected Document(string isbn, string title, int publicationYear, int pageCount)
        {
            ISBN = isbn;
            Title = title;
            PublicationYear = publicationYear;
            PageCount = pageCount;
        }

        public abstract string Print();

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Year: {PublicationYear}, Pages: {PageCount}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Document other)
            {
                return ToString() == other.ToString();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(Document doc1, Document doc2)
        {
            if (doc1 is null && doc2 is null) return true;
            if (doc1 is null || doc2 is null) return false;
            return doc1.Equals(doc2);
        }

        public static bool operator !=(Document doc1, Document doc2)
        {
            return !(doc1 == doc2);
        }
    }
} 