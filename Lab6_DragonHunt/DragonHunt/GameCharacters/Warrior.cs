using System;

namespace GameCharacters
{
    public class Warrior : Character
    {
        public int AttacksPerRound { get; set; }

        public Warrior(string name) : base()
        {
            Name = name;
            Strength = 15;
            Dexterity = 10;
            Intelligence = 8;
            MaxHealth = 100;
            CurrentHealth = MaxHealth;
            Damage = 10;
            DamageResistance = 5;
            AttacksPerRound = 2;
        }

        public override int CalculateDamagePerRound()
        {
            return base.CalculateDamagePerRound() * AttacksPerRound;
        }

        public override void LevelUp()
        {
            base.LevelUp();
            Strength += 3;
            Dexterity += 1;
            Intelligence += 1;
            MaxHealth += 20;
            CurrentHealth = MaxHealth;
            Damage += 2;
            DamageResistance += 1;
        }
    }
} 