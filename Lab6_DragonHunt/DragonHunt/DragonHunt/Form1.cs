using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GameCharacters;

namespace DragonHunt
{
    public partial class Form1 : Form
    {
        private List<Character> party = new List<Character>();
        private Dragon dragon = new Dragon("Dragon");
        private int healingPotions = 3;
        private ToolTip toolTip = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            SetupToolTips();
        }

        private void SetupToolTips()
        {
            // Set tooltip properties
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            // Set tooltips for health bars
            toolTip.SetToolTip(warriorHealthBar, "Warrior's Health");
            toolTip.SetToolTip(archerHealthBar, "Archer's Health");
            toolTip.SetToolTip(wizardHealthBar, "Wizard's Health");
            toolTip.SetToolTip(dragonHealthBar, "Dragon's Health");

            // Set tooltips for buttons
            toolTip.SetToolTip(warriorPotionButton, "Heal Warrior (Uses 1 potion)");
            toolTip.SetToolTip(archerPotionButton, "Heal Archer (Uses 1 potion)");
            toolTip.SetToolTip(wizardPotionButton, "Heal Wizard (Uses 1 potion)");
            toolTip.SetToolTip(fightButton, "Attack the Dragon");
            toolTip.SetToolTip(resetButton, "Reset the Game");

            // Set tooltips for experience buttons
            toolTip.SetToolTip(warriorExpButton, "Add experience to Warrior");
            toolTip.SetToolTip(archerExpButton, "Add experience to Archer");
            toolTip.SetToolTip(wizardExpButton, "Add experience to Wizard");
        }

        private void InitializeGame()
        {
            // Create party members
            party = new List<Character>
            {
                new Warrior("Warrior"),
                new Archer("Archer"),
                new Wizard("Wizard")
            };

            // Create dragon
            dragon = new Dragon("Dragon");
            dragon.Level = 10;
            dragon.Strength = 20;
            dragon.Dexterity = 12;
            dragon.Intelligence = 15;
            dragon.MaxHealth = 500;
            dragon.CurrentHealth = 500;
            dragon.Damage = 30;
            dragon.DamageResistance = 15;
            dragon.ExperienceReward = 1000;

            // Setup dragon's fire breath event
            dragon.OnFireBreath += (intensity) =>
            {
                foreach (var character in party)
                {
                    if (!character.IsDead)
                    {
                        character.TakeDamage(intensity);
                    }
                }
            };

            UpdateUI();
        }

        private void UpdateUI()
        {
            // Update health bars and labels
            warriorHealthBar.Maximum = ((Warrior)party[0]).MaxHealth;
            warriorHealthBar.Value = Math.Max(0, ((Warrior)party[0]).CurrentHealth);
            warriorLabel.Text = party[0].ToString();
            toolTip.SetToolTip(warriorLabel, GetCharacterStats(party[0]));

            archerHealthBar.Maximum = ((Archer)party[1]).MaxHealth;
            archerHealthBar.Value = Math.Max(0, ((Archer)party[1]).CurrentHealth);
            archerLabel.Text = party[1].ToString();
            toolTip.SetToolTip(archerLabel, GetCharacterStats(party[1]));

            wizardHealthBar.Maximum = ((Wizard)party[2]).MaxHealth;
            wizardHealthBar.Value = Math.Max(0, ((Wizard)party[2]).CurrentHealth);
            wizardLabel.Text = party[2].ToString();
            toolTip.SetToolTip(wizardLabel, GetCharacterStats(party[2]));

            dragonHealthBar.Maximum = dragon.MaxHealth;
            dragonHealthBar.Value = Math.Max(0, dragon.CurrentHealth);
            dragonLabel.Text = dragon.ToString();
            toolTip.SetToolTip(dragonLabel, GetCharacterStats(dragon));

            // Update potion count
            potionLabel.Text = $"Healing Potions: {healingPotions}";
            toolTip.SetToolTip(potionLabel, "Number of healing potions remaining");

            // Enable/disable buttons based on game state
            bool gameOver = IsGameOver();
            warriorPotionButton.Enabled = healingPotions > 0 && !gameOver && !party[0].IsDead;
            archerPotionButton.Enabled = healingPotions > 0 && !gameOver && !party[1].IsDead;
            wizardPotionButton.Enabled = healingPotions > 0 && !gameOver && !party[2].IsDead;
            fightButton.Enabled = !gameOver;

            // Update status if game is over
            if (gameOver)
            {
                statusLabel.Text = dragon.IsDead ? 
                    "Heroes won! Dragon is defeated!" : 
                    "Dragon won! All heroes are defeated!";
            }
        }

        private string GetCharacterStats(Character character)
        {
            string stats = $"Level: {character.Level}\n" +
                         $"Health: {character.CurrentHealth}/{character.MaxHealth}\n" +
                         $"Strength: {character.Strength}\n" +
                         $"Dexterity: {character.Dexterity}\n" +
                         $"Intelligence: {character.Intelligence}\n" +
                         $"Damage: {character.Damage}\n" +
                         $"Resistance: {character.DamageResistance}";

            if (character is Warrior warrior)
            {
                stats += $"\nAttacks per Round: {warrior.AttacksPerRound}";
            }
            else if (character is Wizard wizard)
            {
                stats += $"\nMana: {wizard.CurrentMana}/{wizard.MaxMana}";
            }
            else if (character is Dragon dragon)
            {
                stats += $"\nExperience Reward: {dragon.ExperienceReward}";
            }

            return stats;
        }

        private bool IsGameOver()
        {
            return dragon.IsDead || party.TrueForAll(p => p.IsDead);
        }

        private void FightRound()
        {
            if (IsGameOver()) return;

            // Party attacks dragon
            foreach (var character in party)
            {
                if (!character.IsDead)
                {
                    dragon.TakeDamage(character.CalculateDamagePerRound());
                }
            }

            // Dragon breathes fire
            if (!dragon.IsDead)
            {
                dragon.BreatheFire();
            }

            // Check for experience gain
            if (dragon.IsDead)
            {
                foreach (var character in party)
                {
                    if (!character.IsDead)
                    {
                        character.GainExperience(dragon.ExperienceReward / party.Count);
                    }
                }
            }

            UpdateUI();
        }

        private void UsePotion(Character character)
        {
            if (healingPotions > 0 && !character.IsDead)
            {
                character.FullHeal();
                healingPotions--;
                UpdateUI();
            }
        }

        private void warriorPotionButton_Click(object sender, EventArgs e)
        {
            UsePotion(party[0]);
        }

        private void archerPotionButton_Click(object sender, EventArgs e)
        {
            UsePotion(party[1]);
        }

        private void wizardPotionButton_Click(object sender, EventArgs e)
        {
            UsePotion(party[2]);
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            FightRound();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void warriorExpButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(warriorExpTextBox.Text, out int exp))
            {
                party[0].GainExperience(exp);
                UpdateUI();
            }
        }

        private void archerExpButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(archerExpTextBox.Text, out int exp))
            {
                party[1].GainExperience(exp);
                UpdateUI();
            }
        }

        private void wizardExpButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(wizardExpTextBox.Text, out int exp))
            {
                party[2].GainExperience(exp);
                UpdateUI();
            }
        }
    }
} 