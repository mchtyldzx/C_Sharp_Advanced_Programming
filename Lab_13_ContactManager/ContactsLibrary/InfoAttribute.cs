using System;

namespace ContactsLibrary
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute : Attribute
    {
        public string Author { get; }

        public InfoAttribute(string author)
        {
            Author = author;
        }
    }
} 