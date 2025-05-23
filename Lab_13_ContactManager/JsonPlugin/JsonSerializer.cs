using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ContactsLibrary;

namespace JsonPlugin
{
    [Info("Mücahit Yıldız - JSON Plugin Author")]
    public class ContactJsonSerializer : IPluginable
    {
        public string Format => "JSON";

        public void Save(List<Contact> contacts, string filePath)
        {
            var options = new JsonSerializerOptions { 
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(filePath, jsonString);
        }

        public List<Contact> Load(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return System.Text.Json.JsonSerializer.Deserialize<List<Contact>>(jsonString, options) ?? new List<Contact>();
        }
    }
} 