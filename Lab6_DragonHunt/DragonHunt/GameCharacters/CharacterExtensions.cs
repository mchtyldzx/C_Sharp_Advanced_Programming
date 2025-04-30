using System;

namespace GameCharacters
{
    public static class CharacterExtensions
    {
        public static void FullHeal(this Character character)
        {
            character.CurrentHealth = character.MaxHealth;
        }

        public static void RegenerateMana(this Wizard wizard, int amount)
        {
            wizard.CurrentMana = Math.Min(wizard.MaxMana, wizard.CurrentMana + amount);
        }

        public static void UnequipWeapon(this Character character, int damageDecrease)
        {
            character.Damage = Math.Max(0, character.Damage - damageDecrease);
        }

        public static void UnequipArmor(this Character character, int resistanceDecrease)
        {
            character.DamageResistance = Math.Max(0, character.DamageResistance - resistanceDecrease);
        }
    }
} 