using System;
using System.Collections.Generic;
using System.Linq;
using DocumentManagement.Exceptions;

namespace DocumentManagement
{
    public class DocumentManager
    {
        private readonly List<Document> _documents;

        public DocumentManager()
        {
            _documents = new List<Document>();
        }

        public void AddDocument(Document document)
        {
            if (_documents.Any(d => d.ISBN == document.ISBN))
            {
                throw new DocumentAlreadyExistsException($"Document with ISBN {document.ISBN} already exists");
            }
            _documents.Add(document);
        }

        public Document GetDocumentByISBN(string isbn)
        {
            return _documents.FirstOrDefault(d => d.ISBN == isbn);
        }

        public List<Document> SearchByTitle(string phrase)
        {
            return _documents.Where(d => d.Title.Contains(phrase, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Magazine> GetMagazinesByFrequency(PublicationFrequency frequency)
        {
            return _documents.OfType<Magazine>().Where(m => m.Frequency == frequency).ToList();
        }

        public List<Document> GetAllDocuments()
        {
            return _documents;
        }
    }
} 