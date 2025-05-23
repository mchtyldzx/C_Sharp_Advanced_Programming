# Warrior Guild Manager

A Windows Forms application that manages a guild of warriors using XML and LINQ to XML.

## Features

- **XML Data Management**: Create, read, update, and delete warrior data stored in XML format
- **Data Binding**: View warriors in a DataGridView with automatic updates
- **CRUD Operations**: Add, update, delete, and reset warrior information
- **Data Validation**: Prevents duplicate warrior names and empty warrior names
- **Sorting**: Sort warriors by any property in ascending or descending order using reflection
- **File Handling**: 
  - Automatically loads default warriors at startup
  - Interactive file selection dialogs for loading and saving XML files
  - Remembers the application directory for file operations

## Implementation Details

This application demonstrates the use of LINQ to XML to create and manipulate XML documents. Key components include:

### XML Structure

The application uses an XML format with the following structure:
```xml
<guild>
  <warrior gender="Male">
    <name>Conan</name>
    <level>10</level>
    <hp>200</hp>
    <monster>Dragon</monster>
  </warrior>
  <!-- More warriors... -->
</guild>
```

### Data Model

- `Warrior` class represents a warrior with properties:
  - Gender (stored as an attribute in XML)
  - Name (unique identifier)
  - Level
  - HP (Health Points)
  - Monster

### UI Components

- DataGridView for displaying the list of warriors
- ComboBox for warrior selection
- Form fields for editing warrior properties
- Buttons for CRUD operations
- Sorting controls using reflection
- File menu with Load and Save operations

### Main Operations

- Creating and saving XML documents
- Loading warrior data from XML (automatic at startup)
- Interactive file selection using standard dialogs
- Converting between XML elements and C# objects
- Managing CRUD operations
- Sorting warriors by different properties using reflection

## Project Structure

- `Form1.cs`: Main application logic and UI
- `Warrior.cs`: Model class representing a warrior
- Created XML is stored in the application's output directory by default 

## How to Run

1. Clone the repository
2. Open the solution in Visual Studio or use the command line
3. Build and run the application:
   ```
   dotnet build
   dotnet run
   ```