using System.Collections.Generic;

namespace ContactsLibrary
{
    public interface IPluginable
    {
        void Save(List<Contact> contacts, string filePath);
        List<Contact> Load(string filePath);
        string Format { get; }
    }
} 