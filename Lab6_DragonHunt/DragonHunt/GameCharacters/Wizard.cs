using System;

namespace GameCharacters
{
    public class Wizard : Character
    {
        public int CurrentMana { get; set; }
        public int MaxMana { get; private set; }

        public Wizard(string name) : base()
        {
            Name = name;
            Strength = 5;
            Dexterity = 8;
            Intelligence = 15;
            MaxHealth = 80;
            CurrentHealth = MaxHealth;
            Damage = 12;
            DamageResistance = 2;
            
            MaxMana = 100;
            CurrentMana = MaxMana;
        }

        public override int CalculateDamagePerRound()
        {
            if (CurrentMana >= 10)
            {
                CurrentMana -= 10;
                return (int)(Damage * (1 + Intelligence * 0.1));
            }
            return Damage; // Basic attack when out of mana
        }

        public override void LevelUp()
        {
            base.LevelUp();
            Strength += 1;
            Dexterity += 2;
            Intelligence += 4;
            MaxHealth += 10;
            CurrentHealth = MaxHealth;
            Damage += 3;
            DamageResistance += 1;
            
            MaxMana += 20;
            CurrentMana = MaxMana;
        }
    }
} 