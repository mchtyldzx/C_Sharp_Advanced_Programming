using System;
using System.Collections.Generic;
using DocumentManagement;
using DocumentManagement.Exceptions;

namespace DocumentManagementConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new DocumentManager();

            try
            {
                // Add some books
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Adding books...");
                Console.ResetColor();

                var book1 = new Book("978-0-13-235088-4", "Clean Code", 2008, 464, "Robert C. Martin");
                var book2 = new Book("978-0-13-235088-5", "Design Patterns", 1994, 416, "Erich Gamma");
                manager.AddDocument(book1);
                manager.AddDocument(book2);

                // Add some volumes
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nAdding volumes...");
                Console.ResetColor();

                var volume1 = new Volume("978-0-13-235088-6", "The Lord of the Rings", 1954, 1178, 1, 3);
                var volume2 = new Volume("978-0-13-235088-7", "The Lord of the Rings", 1954, 1178, 2, 3);
                manager.AddDocument(volume1);
                manager.AddDocument(volume2);

                // Add some magazines
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nAdding magazines...");
                Console.ResetColor();

                var magazine1 = new Magazine("978-0-13-235088-8", "National Geographic", 2023, 100, 1, PublicationFrequency.Monthly);
                var magazine2 = new Magazine("978-0-13-235088-9", "Time", 2023, 50, 1, PublicationFrequency.Weekly);
                manager.AddDocument(magazine1);
                manager.AddDocument(magazine2);

                // Display all documents
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAll Documents:");
                Console.ResetColor();
                foreach (var doc in manager.GetAllDocuments())
                {
                    Console.WriteLine(doc);
                }

                // Search by title
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSearching for documents with 'Code' in title:");
                Console.ResetColor();
                var searchResults = manager.SearchByTitle("Code");
                foreach (var doc in searchResults)
                {
                    Console.WriteLine(doc);
                }

                // Get magazines by frequency
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nMonthly Magazines:");
                Console.ResetColor();
                var monthlyMagazines = manager.GetMagazinesByFrequency(PublicationFrequency.Monthly);
                foreach (var magazine in monthlyMagazines)
                {
                    Console.WriteLine(magazine);
                }

                // Print all documents
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPrinting all documents:");
                Console.ResetColor();
                foreach (var doc in manager.GetAllDocuments())
                {
                    Console.WriteLine(doc.Print());
                }

                // Test error cases
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTesting error cases:");
                Console.ResetColor();

                // Try to add duplicate ISBN
                try
                {
                    var duplicateBook = new Book("978-0-13-235088-4", "Duplicate Book", 2023, 100, "Test Author");
                    manager.AddDocument(duplicateBook);
                }
                catch (DocumentAlreadyExistsException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Try to add book before printing invention
                try
                {
                    var oldBook = new Book("978-0-13-235089-0", "Ancient Book", 1000, 100, "Ancient Author");
                    manager.AddDocument(oldBook);
                }
                catch (PrintingNotInventedYearException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Try to add invalid volume
                try
                {
                    var invalidVolume = new Volume("978-0-13-235089-1", "Invalid Volume", 2023, 100, 5, 3);
                    manager.AddDocument(invalidVolume);
                }
                catch (VolumeNumberExceedsTotalException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Unexpected error: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
