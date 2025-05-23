using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;
using ContactsLibrary;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        private List<Contact> _contacts;
        private readonly List<IPluginable> _plugins;

        public Form1()
        {
            InitializeComponent();
            _contacts = new List<Contact>();
            _plugins = new List<IPluginable>();
            contactBindingSource.DataSource = _contacts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            try
            {
                string pluginsPath = Path.Combine(Application.StartupPath, "Plugins");
                if (!Directory.Exists(pluginsPath))
                {
                    Directory.CreateDirectory(pluginsPath);
                }

                DirectoryInfo pluginDirectory = new DirectoryInfo(pluginsPath);
                foreach (FileInfo file in pluginDirectory.GetFiles("*.dll"))
                {
                    try
                    {
                        Assembly assembly = Assembly.LoadFrom(file.FullName);
                        foreach (Type type in assembly.GetTypes())
                        {
                            try
                            {
                                if (typeof(IPluginable).IsAssignableFrom(type) && !type.IsInterface)
                                {
                                    if (Activator.CreateInstance(type) is IPluginable plugin)
                                    {
                                        _plugins.Add(plugin);
                                        AddPluginMenuItems(plugin);
                                        AddPluginHelpMenuItem(plugin, type);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error loading plugin type {type.FullName}: {ex.Message}", "Plugin Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading plugin file {file.Name}: {ex.Message}", "Plugin Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing plugins directory: {ex.Message}", "Plugin Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPluginMenuItems(IPluginable plugin)
        {
            var saveMenuItem = new ToolStripMenuItem(plugin.Format);
            saveMenuItem.Click += (s, e) => SaveContacts(plugin);
            saveToToolStripMenuItem.DropDownItems.Add(saveMenuItem);

            var loadMenuItem = new ToolStripMenuItem(plugin.Format);
            loadMenuItem.Click += (s, e) => LoadContacts(plugin);
            loadFromToolStripMenuItem.DropDownItems.Add(loadMenuItem);
        }

        private void AddPluginHelpMenuItem(IPluginable plugin, Type pluginType)
        {
            var infoAttr = pluginType.GetCustomAttribute<InfoAttribute>();
            if (infoAttr != null)
            {
                var helpMenuItem = new ToolStripMenuItem(plugin.Format);
                helpMenuItem.Click += (s, e) => MessageBox.Show($"Plugin Author: {infoAttr.Author}", "Plugin Info");
                helpToolStripMenuItem.DropDownItems.Add(helpMenuItem);
            }
        }

        private void SaveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "XML files (*.xml)|*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
                            serializer.Serialize(stream, _contacts);
                        }
                        MessageBox.Show("Contacts saved successfully in XML format.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving contacts: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "XML files (*.xml)|*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(dialog.FileName, FileMode.Open))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
                            var loadedContacts = (List<Contact>?)serializer.Deserialize(stream);
                            if (loadedContacts != null)
                            {
                                _contacts.Clear();
                                _contacts.AddRange(loadedContacts);
                                contactBindingSource.ResetBindings(false);
                                MessageBox.Show("Contacts loaded successfully from XML format.", "Load Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading contacts: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveContacts(IPluginable plugin)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = $"{plugin.Format} files (*.{plugin.Format.ToLower()})|*.{plugin.Format.ToLower()}";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        plugin.Save(_contacts, dialog.FileName);
                        MessageBox.Show($"Contacts saved successfully in {plugin.Format} format.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving contacts: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadContacts(IPluginable plugin)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = $"{plugin.Format} files (*.{plugin.Format.ToLower()})|*.{plugin.Format.ToLower()}";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var loadedContacts = plugin.Load(dialog.FileName);
                        if (loadedContacts != null)
                        {
                            _contacts.Clear();
                            _contacts.AddRange(loadedContacts);
                            contactBindingSource.ResetBindings(false);
                            MessageBox.Show($"Contacts loaded successfully from {plugin.Format} format.", "Load Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading contacts: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
} 