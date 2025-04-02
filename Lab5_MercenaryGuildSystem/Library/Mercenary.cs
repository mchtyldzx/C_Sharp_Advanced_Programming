using System;

namespace MercenaryGuild.Library
{
    public class Mercenary
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int GoldCoins { get; set; }

        public Mercenary()
        {
        }

        public Mercenary(string name, int level, int experiencePoints, int maxHealth, int damage, int goldCoins)
        {
            Name = name;
            Level = level;
            ExperiencePoints = experiencePoints;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Damage = damage;
            GoldCoins = goldCoins;
        }

        public override string ToString()
        {
            return $"Mercenary: {Name}, Level: {Level}, HP: {CurrentHealth}/{MaxHealth}, Damage: {Damage}, XP: {ExperiencePoints}, Gold: {GoldCoins}";
        }
    }
} 