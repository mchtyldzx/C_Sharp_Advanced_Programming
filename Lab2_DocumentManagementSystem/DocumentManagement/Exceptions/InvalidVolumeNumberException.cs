using System;

namespace DocumentManagement.Exceptions
{
    public class InvalidVolumeNumberException : Exception
    {
        public InvalidVolumeNumberException(string message) : base(message)
        {
        }
    }
} 