using System;

namespace DocumentManagement.Exceptions
{
    public class DocumentAlreadyExistsException : Exception
    {
        public DocumentAlreadyExistsException(string message) : base(message)
        {
        }
    }
} 