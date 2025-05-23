# Contact Manager with Plugin System

This is a Windows Forms application for managing contact information, designed with a plugin system that enables dynamic support for different data formats such as XML and JSON.

## Project Structure

The solution consists of three main projects:

- **ContactsLibrary**: Common library
  - `Contact`: Class representing contact information (first name, last name, phone, email, discord)
  - `IPluginable`: Interface for developing plugins (Save, Load, and Format members)
  - `InfoAttribute`: Attribute for storing plugin author information

- **ContactManager**: Main Windows Forms application
  - Contact management with DataGridView
  - Plugin system implementation
  - XML serialization built-in

- **JsonPlugin**: JSON serialization plugin example
  - Implemented using System.Text.Json

## Setup and Running

1. Build the solution

2. Locate the JsonPlugin.dll file in:
   - `JsonPlugin/bin/Debug/net8.0/JsonPlugin.dll`

3. Copy this file to the Plugins folder in the ContactManager output directory:
   - `ContactManager/bin/Debug/net8.0-windows/Plugins/`

4. Run the ContactManager application


## Plugin System

The application can dynamically load classes that implement the IPluginable interface using the reflection mechanism. This allows adding new serialization formats without recompiling the application.

## Creating a Plugin

1. Create a new .NET Class Library project
2. Add a reference to the ContactsLibrary project
3. Write a class that implements the IPluginable interface:
   ```csharp
   [Info("Name")]
   public class NewSerializer : IPluginable
   {
       public string Format => "FORMAT_NAME";
       
       public void Save(List<Contact> contacts, string filePath)
       {
           // Save operations
       }
       
       public List<Contact> Load(string filePath)
       {
           // Load operations
           return new List<Contact>();
       }
   }
   ```
4. Copy the resulting DLL to the Plugins folder
