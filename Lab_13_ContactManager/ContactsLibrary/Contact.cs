using System;

namespace ContactsLibrary
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Discord { get; set; }

        public Contact()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Discord = string.Empty;
        }
    }
} 