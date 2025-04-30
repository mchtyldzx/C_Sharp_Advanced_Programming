using System;

namespace GameCharacters
{
    public abstract class Character : IComparable<Character>
    {
        // Properties
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int DamageResistance { get; set; }

        // Constructors
        protected Character()
        {
            Name = string.Empty;
            Level = 1;
            Experience = 0;
        }

        protected Character(string name, int level, int experience, int strength, int dexterity, 
            int intelligence, int currentHealth, int maxHealth, int damage, int damageResistance)
        {
            Name = name;
            Level = level;
            Experience = experience;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            Damage = damage;
            DamageResistance = damageResistance;
        }

        // Methods
        public override string ToString()
        {
            return $"{Name} (Level {Level}) - HP: {CurrentHealth}/{MaxHealth}";
        }

        public virtual void EquipWeapon(int damageIncrease)
        {
            Damage += damageIncrease;
        }

        public virtual void EquipArmor(int resistanceIncrease)
        {
            DamageResistance += resistanceIncrease;
        }

        public virtual int CalculateDamagePerRound()
        {
            return Damage;
        }

        public virtual void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - DamageResistance);
            CurrentHealth = Math.Max(0, CurrentHealth - actualDamage);
        }

        public bool IsDead => CurrentHealth <= 0;

        public virtual void LevelUp()
        {
            Level++;
            MaxHealth += 10;
            CurrentHealth = MaxHealth;
            Experience = 0;
        }

        public void GainExperience(int amount)
        {
            Experience += amount;
            if (Experience >= Level * 100) // Simple level up formula
            {
                LevelUp();
            }
        }

        public int CompareTo(Character? other)
        {
            if (other == null) return 1;
            return Level.CompareTo(other.Level);
        }
    }
} 