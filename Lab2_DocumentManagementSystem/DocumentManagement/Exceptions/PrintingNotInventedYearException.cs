using System;

namespace DocumentManagement.Exceptions
{
    public class PrintingNotInventedYearException : Exception
    {
        public PrintingNotInventedYearException(string message) : base(message)
        {
        }
    }
} 
