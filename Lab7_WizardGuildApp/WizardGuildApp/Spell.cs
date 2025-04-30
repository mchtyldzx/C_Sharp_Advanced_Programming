using System;

namespace WizardGuildApp
{
    public enum SpellType
    {
        Offensive,
        Defensive,
        Healing
    }

    public class Spell
    {
        public string Name { get; set; }
        public SpellType Type { get; set; }
        public int ManaCost { get; set; }
        public int Cooldown { get; set; }
        public int Effect { get; set; }

        public override string ToString()
        {
            return $"Spell: {Name}, Type: {Type}, Mana Cost: {ManaCost}, Cooldown: {Cooldown}, Effect: {Effect}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Spell other)
            {
                return this.ToString() == other.ToString();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
} 