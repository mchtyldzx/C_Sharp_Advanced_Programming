using System;

namespace GameCharacters
{
    public class Archer : Character
    {
        public double DodgeChance { get; set; }
        private Random random = new Random();

        public Archer(string name) : base()
        {
            Name = name;
            Strength = 10;
            Dexterity = 15;
            Intelligence = 8;
            MaxHealth = 80;
            CurrentHealth = MaxHealth;
            Damage = 12;
            DamageResistance = 3;
            DodgeChance = 0.2; // 20% chance to dodge
        }

        public override void TakeDamage(int damage)
        {
            if (random.NextDouble() < DodgeChance)
            {
                return; // Dodge successful
            }
            base.TakeDamage(damage);
        }

        public override void LevelUp()
        {
            base.LevelUp();
            Strength += 1;
            Dexterity += 3;
            Intelligence += 1;
            MaxHealth += 15;
            CurrentHealth = MaxHealth;
            Damage += 3;
            DodgeChance += 0.02; // Increase dodge chance by 2% per level
        }
    }
} 