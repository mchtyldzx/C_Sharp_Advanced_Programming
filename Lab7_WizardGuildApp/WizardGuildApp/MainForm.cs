using System;
using System.Windows.Forms;
using WizardGuildApp;

namespace WizardGuildApp
{
    public partial class MainForm : Form
    {
        private WizardGuild guild;

        public MainForm()
        {
            InitializeComponent();
            InitializeGuild();
            InitializeUI();
        }

        private void InitializeGuild()
        {
            guild = new WizardGuild();

            // Veigar - The Tiny Master of Evil
            var veigar = new Wizard
            {
                Name = "Veigar",
                Level = 95,
                Experience = 9500,
                Strength = 40,
                Dexterity = 60,
                Intelligence = 100,
                CurrentHealth = 850,
                MaxHealth = 850,
                CurrentMana = 1000,
                MaxMana = 1000,
                Damage = 200,
                PhysicalResistance = 30,
                FireResistance = 70,
                FrostResistance = 60,
                PoisonResistance = 40
            };
            veigar.SpellBook.Add(new Spell { Name = "Dark Matter", Type = SpellType.Offensive, ManaCost = 70, Cooldown = 8, Effect = 150 });
            veigar.SpellBook.Add(new Spell { Name = "Baleful Strike", Type = SpellType.Offensive, ManaCost = 30, Cooldown = 5, Effect = 80 });
            veigar.SpellBook.Add(new Spell { Name = "Event Horizon", Type = SpellType.Defensive, ManaCost = 80, Cooldown = 12, Effect = 100 });
            veigar.SpellBook.Add(new Spell { Name = "Primordial Burst", Type = SpellType.Offensive, ManaCost = 100, Cooldown = 15, Effect = 200 });

            // Lux - The Lady of Luminosity
            var lux = new Wizard
            {
                Name = "Lux",
                Level = 92,
                Experience = 9200,
                Strength = 45,
                Dexterity = 70,
                Intelligence = 95,
                CurrentHealth = 900,
                MaxHealth = 900,
                CurrentMana = 950,
                MaxMana = 950,
                Damage = 180,
                PhysicalResistance = 35,
                FireResistance = 65,
                FrostResistance = 65,
                PoisonResistance = 45
            };
            lux.SpellBook.Add(new Spell { Name = "Light Binding", Type = SpellType.Offensive, ManaCost = 50, Cooldown = 6, Effect = 90 });
            lux.SpellBook.Add(new Spell { Name = "Prismatic Barrier", Type = SpellType.Defensive, ManaCost = 60, Cooldown = 8, Effect = 120 });
            lux.SpellBook.Add(new Spell { Name = "Lucent Singularity", Type = SpellType.Offensive, ManaCost = 70, Cooldown = 10, Effect = 130 });
            lux.SpellBook.Add(new Spell { Name = "Final Spark", Type = SpellType.Offensive, ManaCost = 100, Cooldown = 15, Effect = 200 });

            // Ryze - The Rune Mage
            var ryze = new Wizard
            {
                Name = "Ryze",
                Level = 98,
                Experience = 9800,
                Strength = 60,
                Dexterity = 65,
                Intelligence = 98,
                CurrentHealth = 1000,
                MaxHealth = 1000,
                CurrentMana = 1200,
                MaxMana = 1200,
                Damage = 190,
                PhysicalResistance = 45,
                FireResistance = 60,
                FrostResistance = 70,
                PoisonResistance = 50
            };
            ryze.SpellBook.Add(new Spell { Name = "Overload", Type = SpellType.Offensive, ManaCost = 40, Cooldown = 4, Effect = 85 });
            ryze.SpellBook.Add(new Spell { Name = "Rune Prison", Type = SpellType.Defensive, ManaCost = 50, Cooldown = 7, Effect = 110 });
            ryze.SpellBook.Add(new Spell { Name = "Spell Flux", Type = SpellType.Offensive, ManaCost = 60, Cooldown = 9, Effect = 120 });
            ryze.SpellBook.Add(new Spell { Name = "Realm Warp", Type = SpellType.Defensive, ManaCost = 100, Cooldown = 20, Effect = 150 });

            // Ahri - The Nine-Tailed Fox
            var ahri = new Wizard
            {
                Name = "Ahri",
                Level = 93,
                Experience = 9300,
                Strength = 50,
                Dexterity = 85,
                Intelligence = 90,
                CurrentHealth = 880,
                MaxHealth = 880,
                CurrentMana = 900,
                MaxMana = 900,
                Damage = 170,
                PhysicalResistance = 40,
                FireResistance = 75,
                FrostResistance = 55,
                PoisonResistance = 60
            };
            ahri.SpellBook.Add(new Spell { Name = "Orb of Deception", Type = SpellType.Offensive, ManaCost = 55, Cooldown = 7, Effect = 95 });
            ahri.SpellBook.Add(new Spell { Name = "Fox-Fire", Type = SpellType.Offensive, ManaCost = 45, Cooldown = 5, Effect = 80 });
            ahri.SpellBook.Add(new Spell { Name = "Charm", Type = SpellType.Offensive, ManaCost = 70, Cooldown = 12, Effect = 140 });
            ahri.SpellBook.Add(new Spell { Name = "Spirit Rush", Type = SpellType.Offensive, ManaCost = 100, Cooldown = 15, Effect = 180 });

            // Syndra - The Dark Sovereign
            var syndra = new Wizard
            {
                Name = "Syndra",
                Level = 96,
                Experience = 9600,
                Strength = 45,
                Dexterity = 65,
                Intelligence = 99,
                CurrentHealth = 870,
                MaxHealth = 870,
                CurrentMana = 980,
                MaxMana = 980,
                Damage = 195,
                PhysicalResistance = 35,
                FireResistance = 70,
                FrostResistance = 65,
                PoisonResistance = 55
            };
            syndra.SpellBook.Add(new Spell { Name = "Dark Sphere", Type = SpellType.Offensive, ManaCost = 50, Cooldown = 6, Effect = 100 });
            syndra.SpellBook.Add(new Spell { Name = "Force of Will", Type = SpellType.Offensive, ManaCost = 60, Cooldown = 8, Effect = 120 });
            syndra.SpellBook.Add(new Spell { Name = "Scatter the Weak", Type = SpellType.Defensive, ManaCost = 70, Cooldown = 10, Effect = 130 });
            syndra.SpellBook.Add(new Spell { Name = "Unleashed Power", Type = SpellType.Offensive, ManaCost = 100, Cooldown = 15, Effect = 210 });

            guild.AddWizard(veigar);
            guild.AddWizard(lux);
            guild.AddWizard(ryze);
            guild.AddWizard(ahri);
            guild.AddWizard(syndra);
        }

        private void InitializeUI()
        {
            this.Text = "Wizard Guild Management";
            this.Size = new System.Drawing.Size(1200, 800);

            // Create ListBox for results
            var resultsListBox = new ListBox
            {
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(700, 700),
                Font = new System.Drawing.Font("Consolas", 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };
            this.Controls.Add(resultsListBox);

            // Create FlowLayoutPanel for buttons
            var buttonPanel = new FlowLayoutPanel
            {
                Location = new System.Drawing.Point(740, 20),
                Size = new System.Drawing.Size(420, 700),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
            };
            this.Controls.Add(buttonPanel);

            // Create buttons and their handlers
            var buttons = new[]
            {
                new { Text = "1. Get All Wizards", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    foreach (var wizard in guild.GetAllWizards())
                    {
                        resultsListBox.Items.Add($"Name: {wizard.Name}");
                        resultsListBox.Items.Add($"Level: {wizard.Level}, Experience: {wizard.Experience}");
                        resultsListBox.Items.Add($"Stats: STR {wizard.Strength}, DEX {wizard.Dexterity}, INT {wizard.Intelligence}");
                        resultsListBox.Items.Add($"Health: {wizard.CurrentHealth}/{wizard.MaxHealth}, Mana: {wizard.CurrentMana}/{wizard.MaxMana}");
                        resultsListBox.Items.Add($"Resistances: Physical {wizard.PhysicalResistance}, Fire {wizard.FireResistance}, " +
                                               $"Frost {wizard.FrostResistance}, Poison {wizard.PoisonResistance}");
                        resultsListBox.Items.Add("----------------------------------------");
                    }
                })},
                new { Text = "2. Get Experienced Wizards", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var level = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter minimum level:", "Level"));
                    foreach (var wizard in guild.GetExperiencedWizards(level))
                        resultsListBox.Items.Add(wizard.ToString());
                })},
                new { Text = "3. Get Talented Wizards", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var level = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter maximum level:", "Level"));
                    foreach (var wizard in guild.GetTalentedWizards(level))
                        resultsListBox.Items.Add(wizard.ToString());
                })},
                new { Text = "4. Get Total Mana Potential", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    resultsListBox.Items.Add($"Total Mana Potential: {guild.GetTotalManaPotential()}");
                })},
                new { Text = "5. Get Wizards with Large Spell Arsenal", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var minSpells = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter minimum number of spells:", "Spells"));
                    foreach (var (Name, Count, Mana) in guild.GetWizardsWithLargeSpellArsenal(minSpells))
                        resultsListBox.Items.Add($"Name: {Name}, Spells: {Count}, Mana: {Mana}");
                })},
                new { Text = "6. Get Most Versatile Wizards", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    foreach (var (Name, Level, Average) in guild.GetMostVersatileWizards())
                        resultsListBox.Items.Add($"Name: {Name}, Level: {Level}, Average: {Average:F2}");
                })},
                new { Text = "7. Get Wizards with Most Spells", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    foreach (var wizard in guild.GetWizardsWithMostSpells())
                        resultsListBox.Items.Add(wizard.ToString());
                })},
                new { Text = "8. Get All Unique Spells", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    foreach (var spell in guild.GetAllUniqueSpells())
                        resultsListBox.Items.Add(spell.ToString());
                })},
                new { Text = "9. Get Spells by Type", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var type = (SpellType)Enum.Parse(typeof(SpellType), 
                        Microsoft.VisualBasic.Interaction.InputBox("Enter spell type (Offensive/Defensive/Healing):", "Type"));
                    foreach (var spell in guild.GetSpellsByType(type))
                        resultsListBox.Items.Add(spell.ToString());
                })},
                new { Text = "10. Get Spells by Type for Wizard", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var name = Microsoft.VisualBasic.Interaction.InputBox("Enter wizard name:", "Name");
                    var type = (SpellType)Enum.Parse(typeof(SpellType), 
                        Microsoft.VisualBasic.Interaction.InputBox("Enter spell type (Offensive/Defensive/Healing):", "Type"));
                    foreach (var spell in guild.GetSpellsByTypeForWizard(name, type))
                        resultsListBox.Items.Add(spell.ToString());
                })},
                new { Text = "11. Get Spell Count by Type", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    foreach (var (Type, Count) in guild.GetSpellCountByType())
                        resultsListBox.Items.Add($"Type: {Type}, Count: {Count}");
                })},
                new { Text = "12. Get Spell Count by Type for Wizard", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var name = Microsoft.VisualBasic.Interaction.InputBox("Enter wizard name:", "Name");
                    foreach (var (Type, Count) in guild.GetSpellCountByTypeForWizard(name))
                        resultsListBox.Items.Add($"Type: {Type}, Count: {Count}");
                })},
                new { Text = "13. Get Most Powerful Wizards", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var skip = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter number of wizards to skip:", "Skip"));
                    var take = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter number of wizards to take:", "Take"));
                    foreach (var (Name, Level) in guild.GetMostPowerfulWizards(skip, take))
                        resultsListBox.Items.Add($"Name: {Name}, Level: {Level}");
                })},
                new { Text = "14. Check Tournament Readiness", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    resultsListBox.Items.Add($"All wizards ready: {guild.AreAllWizardsReadyForTournament()}");
                })},
                new { Text = "15. Check for Unconscious Wizards", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    resultsListBox.Items.Add($"Any wizard unconscious: {guild.IsAnyWizardUnconscious()}");
                })},
                new { Text = "16. Get Best Wizards for Special Mission", Handler = (EventHandler)((s, e) => {
                    resultsListBox.Items.Clear();
                    var minLevel = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter minimum level:", "Level"));
                    var count = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter number of wizards:", "Count"));
                    foreach (var (Name, Level, TotalResistance, Physical, Fire, Frost, Poison) 
                        in guild.GetBestWizardsForSpecialMission(minLevel, count))
                    {
                        resultsListBox.Items.Add($"Name: {Name}, Level: {Level}, Total Resistance: {TotalResistance}");
                        resultsListBox.Items.Add($"Physical: {Physical}, Fire: {Fire}, Frost: {Frost}, Poison: {Poison}");
                        resultsListBox.Items.Add("");
                    }
                })}
            };

            // Add buttons to panel
            foreach (var buttonInfo in buttons)
            {
                var button = new Button
                {
                    Text = buttonInfo.Text,
                    Size = new System.Drawing.Size(380, 35),
                    Margin = new Padding(5),
                    Font = new System.Drawing.Font("Segoe UI", 9)
                };
                button.Click += buttonInfo.Handler;
                buttonPanel.Controls.Add(button);
            }
        }
    }
} 