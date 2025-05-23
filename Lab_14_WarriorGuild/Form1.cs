using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WarriorGuild;

public partial class Form1 : Form
{
    private List<Warrior> _warriors;
    private string[] _genders = { "Male", "Female" };

    public Form1()
    {
        InitializeComponent();
        _warriors = new List<Warrior>();
        
        // Create the initial XML and warrior list
        CreateInitialXmlDocument();
        LoadWarriorsFromXmlAuto();
        
        // Set up data bindings
        dataGridViewWarriors.DataSource = _warriors;
        comboBoxWarriors.DataSource = _warriors;
        comboBoxWarriors.DisplayMember = "Name";
        
        comboBoxGender.DataSource = _genders;
        
        // Set up property sort list with reflection
        PropertyInfo[] properties = typeof(Warrior).GetProperties();
        comboBoxSortProperty.DataSource = properties;
        comboBoxSortProperty.DisplayMember = "Name";
        
        // Set default radio button selection
        radioButtonAscending.Checked = true;
        
        // Hook up event handlers
        comboBoxWarriors.SelectedIndexChanged += ComboBoxWarriors_SelectedIndexChanged;
    }
    
    private void CreateInitialXmlDocument()
    {
        // Create an XML document representing a guild of warriors
        XElement guild = new XElement("guild",
            new XElement("warrior", 
                new XAttribute("gender", "Male"),
                new XElement("name", "Conan"),
                new XElement("level", 10),
                new XElement("hp", 200),
                new XElement("monster", "Dragon")
            ),
            new XElement("warrior", 
                new XAttribute("gender", "Female"),
                new XElement("name", "Xena"),
                new XElement("level", 15),
                new XElement("hp", 180),
                new XElement("monster", "Cyclops")
            ),
            new XElement("warrior", 
                new XAttribute("gender", "Male"),
                new XElement("name", "Aragorn"),
                new XElement("level", 20),
                new XElement("hp", 250),
                new XElement("monster", "Balrog")
            )
        );
        
        // Save the XML document to a file
        string path = Path.Combine(Application.StartupPath, "warriors.xml");
        guild.Save(path);
    }
    
    private void LoadWarriorsFromXmlAuto()
    {
        try
        {
            string path = Path.Combine(Application.StartupPath, "warriors.xml");
            if (!File.Exists(path))
            {
                // No need to show error message on startup if file doesn't exist
                // It's expected initially and we already created a default file
                return;
            }
            
            // Load the XML document
            XElement guild = XElement.Load(path);
            
            // Clear current list
            _warriors.Clear();
            
            // Convert XML elements to Warrior objects
            var warriors = guild.Elements("warrior")
                .Select(w => new Warrior(
                    w.Attribute("gender")?.Value ?? "Unknown",
                    w.Element("name")?.Value ?? "Unknown",
                    int.Parse(w.Element("level")?.Value ?? "1"),
                    int.Parse(w.Element("hp")?.Value ?? "100"),
                    w.Element("monster")?.Value ?? "None"
                ));
                
            // Add all warriors to the list
            _warriors.AddRange(warriors);
            
            // Refresh data bindings
            RefreshDataBindings();
        }
        catch (Exception ex)
        {
            // Silent fail on startup or show a non-intrusive message
            Console.WriteLine($"Error loading initial XML: {ex.Message}");
        }
    }
    
    private void LoadWarriorsFromXml()
    {
        try
        {
            // Create and configure OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Select Warriors XML File";
                openFileDialog.InitialDirectory = Application.StartupPath; // Set initial directory to application folder

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    
                    // Load the XML document
                    XElement guild = XElement.Load(path);
                    
                    // Clear current list
                    _warriors.Clear();
                    
                    // Convert XML elements to Warrior objects
                    var warriors = guild.Elements("warrior")
                        .Select(w => new Warrior(
                            w.Attribute("gender")?.Value ?? "Unknown",
                            w.Element("name")?.Value ?? "Unknown",
                            int.Parse(w.Element("level")?.Value ?? "1"),
                            int.Parse(w.Element("hp")?.Value ?? "100"),
                            w.Element("monster")?.Value ?? "None"
                        ));
                        
                    // Add all warriors to the list
                    _warriors.AddRange(warriors);
                    
                    // Refresh data bindings
                    RefreshDataBindings();
                    
                    MessageBox.Show("Warriors loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void SaveWarriorsToXml()
    {
        try
        {
            // Create and configure SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Save Warriors XML File";
                saveFileDialog.FileName = "warriors.xml";
                saveFileDialog.DefaultExt = "xml";
                saveFileDialog.InitialDirectory = Application.StartupPath; // Set initial directory to application folder
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;
                    
                    // Create XML structure from warrior list
                    XElement guild = new XElement("guild",
                        _warriors.Select(w => new XElement("warrior",
                            new XAttribute("gender", w.Gender ?? "Unknown"),
                            new XElement("name", w.Name ?? "Unknown"),
                            new XElement("level", w.Level),
                            new XElement("hp", w.HP),
                            new XElement("monster", w.Monster ?? "None")
                        ))
                    );
                    
                    // Save the XML document
                    guild.Save(path);
                    MessageBox.Show("XML saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void RefreshDataBindings()
    {
        // Refresh data bindings for controls
        var bindingSource = new BindingSource
        {
            DataSource = null
        };
        bindingSource.DataSource = _warriors;

        // Update DataGridView
        dataGridViewWarriors.DataSource = bindingSource;
        
        // Update ComboBox (preserving selection if possible)
        object? selectedItem = comboBoxWarriors.SelectedItem;
        comboBoxWarriors.DataSource = null;
        comboBoxWarriors.DataSource = _warriors;
        
        // Fix for null reference warning by checking if the cast to Warrior is not null
        Warrior? warrior = selectedItem as Warrior;
        if (selectedItem != null && warrior != null && _warriors.Contains(warrior))
        {
            comboBoxWarriors.SelectedItem = selectedItem;
        }
    }
    
    private void ComboBoxWarriors_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (comboBoxWarriors.SelectedItem is Warrior selectedWarrior)
        {
            // Fill form fields with the selected warrior's data
            textBoxName.Text = selectedWarrior.Name ?? string.Empty;
            numericUpDownLevel.Value = selectedWarrior.Level;
            numericUpDownHP.Value = selectedWarrior.HP;
            textBoxMonster.Text = selectedWarrior.Monster ?? string.Empty;
            comboBoxGender.SelectedItem = selectedWarrior.Gender;
        }
    }
    
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        // Check if the name already exists
        if (string.IsNullOrEmpty(textBoxName.Text))
        {
            MessageBox.Show("Warrior name cannot be empty!", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        if (_warriors.Any(w => w.Name == textBoxName.Text))
        {
            MessageBox.Show("A warrior with this name already exists in the guild!", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        // Create a new warrior
        Warrior newWarrior = new Warrior(
            comboBoxGender.SelectedItem?.ToString() ?? "Unknown",
            textBoxName.Text,
            (int)numericUpDownLevel.Value,
            (int)numericUpDownHP.Value,
            textBoxMonster.Text
        );
        
        // Add to the list and refresh
        _warriors.Add(newWarrior);
        RefreshDataBindings();
    }
    
    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        if (comboBoxWarriors.SelectedItem is Warrior selectedWarrior)
        {
            // Update the selected warrior with form values
            selectedWarrior.Name = textBoxName.Text;
            selectedWarrior.Level = (int)numericUpDownLevel.Value;
            selectedWarrior.HP = (int)numericUpDownHP.Value;
            selectedWarrior.Monster = textBoxMonster.Text;
            selectedWarrior.Gender = comboBoxGender.SelectedItem?.ToString() ?? selectedWarrior.Gender;
            
            // Refresh the display
            RefreshDataBindings();
        }
    }
    
    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (comboBoxWarriors.SelectedItem is Warrior selectedWarrior)
        {
            // Remove the selected warrior
            _warriors.Remove(selectedWarrior);
            RefreshDataBindings();
        }
    }
    
    private void buttonReset_Click(object sender, EventArgs e)
    {
        // Reset form fields to default values
        textBoxName.Text = "";
        numericUpDownLevel.Value = 1;
        numericUpDownHP.Value = 100;
        textBoxMonster.Text = "";
        comboBoxGender.SelectedIndex = 0;
    }
    
    private void buttonSort_Click(object sender, EventArgs e)
    {
        if (comboBoxSortProperty.SelectedItem is PropertyInfo selectedProperty)
        {
            List<Warrior> sortedList;
            
            if (radioButtonAscending.Checked)
            {
                // Sort ascending
                sortedList = _warriors.OrderBy(w => selectedProperty.GetValue(w)).ToList();
            }
            else
            {
                // Sort descending
                sortedList = _warriors.OrderByDescending(w => selectedProperty.GetValue(w)).ToList();
            }
            
            // Replace contents with sorted list
            _warriors.Clear();
            _warriors.AddRange(sortedList);
            RefreshDataBindings();
        }
    }
    
    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadWarriorsFromXml();
    }
    
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveWarriorsToXml();
    }
} 