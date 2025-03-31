using System;

namespace DocumentManagement.Exceptions
{
    public class InvalidPublicationYearException : Exception
    {
        public InvalidPublicationYearException(string message) : base(message)
        {
        }
    }
} 