using System;

namespace DocumentManagement.Exceptions
{
    public class VolumeNumberExceedsTotalException : Exception
    {
        public VolumeNumberExceedsTotalException(string message) : base(message)
        {
        }
    }
} 
