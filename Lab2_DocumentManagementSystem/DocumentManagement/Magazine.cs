using System;

namespace DocumentManagement
{
    public enum PublicationFrequency
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public class Magazine : Document
    {
        public int IssueNumber { get; set; }
        public PublicationFrequency Frequency { get; set; }

        public Magazine() : base()
        {
            // Default constructor
        }

        public Magazine(string isbn, string title, int publicationYear, int pageCount, int issueNumber, PublicationFrequency frequency)
            : base(isbn, title, publicationYear, pageCount)
        {
            IssueNumber = issueNumber;
            Frequency = frequency;
        }

        public override string Print()
        {
            return $"Printing magazine: {Title} Issue {IssueNumber} ({Frequency})";
        }

        public override string ToString()
        {
            return $"Magazine - {base.ToString()}, Issue: {IssueNumber}, Frequency: {Frequency}";
        }
    }
} 