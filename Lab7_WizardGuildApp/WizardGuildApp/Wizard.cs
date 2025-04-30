using System;

namespace WizardGuildApp
{
    public class Wizard
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentMana { get; set; }
        public int MaxMana { get; set; }
        public int Damage { get; set; }
        public int PhysicalResistance { get; set; }
        public int FireResistance { get; set; }
        public int FrostResistance { get; set; }
        public int PoisonResistance { get; set; }
        public SpellBook SpellBook { get; set; }

        public Wizard()
        {
            SpellBook = new SpellBook();
        }

        public override string ToString()
        {
            return $"Wizard: {Name}, Level: {Level}, Experience: {Experience}, " +
                   $"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}, " +
                   $"Health: {CurrentHealth}/{MaxHealth}, Mana: {CurrentMana}/{MaxMana}, " +
                   $"Damage: {Damage}, Physical Resistance: {PhysicalResistance}, " +
                   $"Fire Resistance: {FireResistance}, Frost Resistance: {FrostResistance}, " +
                   $"Poison Resistance: {PoisonResistance}";
        }
    }
} 