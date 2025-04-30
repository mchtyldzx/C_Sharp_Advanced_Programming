using System;
using System.Collections.Generic;
using System.Linq;

namespace WizardGuildApp
{
    public class WizardGuild
    {
        private List<Wizard> wizards = new List<Wizard>();

        public void AddWizard(Wizard wizard)
        {
            wizards.Add(wizard);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, wizards.Select(w => w.ToString()));
        }

        // 1. Get all wizards sorted by name
        public IEnumerable<Wizard> GetAllWizards()
        {
            return wizards.OrderBy(w => w.Name);
        }

        // 2. Get experienced wizards above given level
        public IEnumerable<Wizard> GetExperiencedWizards(int minLevel)
        {
            return wizards.Where(w => w.Level > minLevel)
                         .OrderBy(w => w.Level);
        }

        // 3. Get talented wizards
        public IEnumerable<Wizard> GetTalentedWizards(int maxLevel)
        {
            return wizards.Where(w => w.Intelligence > 20 && w.Level <= maxLevel)
                         .OrderByDescending(w => w.Intelligence);
        }

        // 4. Get total mana potential of battle wizards
        public int GetTotalManaPotential()
        {
            return wizards.Where(w => w.Level > 2 && w.Dexterity > 10)
                         .Sum(w => w.MaxMana);
        }

        // 5. Get wizards with largest spell arsenal
        public IEnumerable<(string Name, int SpellCount, int Mana)> GetWizardsWithLargeSpellArsenal(int minSpells)
        {
            return wizards.Where(w => w.SpellBook.Count >= minSpells)
                         .Select(w => (w.Name, SpellCount: w.SpellBook.Count, w.MaxMana))
                         .OrderByDescending(x => x.SpellCount);
        }

        // 6. Get most versatile wizards
        public IEnumerable<(string Name, int Level, double Average)> GetMostVersatileWizards()
        {
            return wizards.Select(w => (
                w.Name,
                w.Level,
                Average: (w.Strength + w.Dexterity + w.Intelligence) / 3.0
            )).OrderByDescending(x => x.Average);
        }

        // 7. Get wizards with most spells
        public IEnumerable<Wizard> GetWizardsWithMostSpells()
        {
            int maxSpells = wizards.Max(w => w.SpellBook.Count);
            return wizards.Where(w => w.SpellBook.Count == maxSpells);
        }

        // 8. Get all unique spells
        public IEnumerable<Spell> GetAllUniqueSpells()
        {
            return wizards.SelectMany(w => w.SpellBook).Distinct();
        }

        // 9. Get spells by type
        public IEnumerable<Spell> GetSpellsByType(SpellType type)
        {
            return wizards.SelectMany(w => w.SpellBook)
                         .Where(s => s.Type == type)
                         .Distinct();
        }

        // 10. Get spells by type for specific wizard
        public IEnumerable<Spell> GetSpellsByTypeForWizard(string wizardName, SpellType type)
        {
            var wizard = wizards.Single(w => w.Name == wizardName);
            return wizard.SpellBook.Where(s => s.Type == type);
        }

        // 11. Get spell count by type
        public IEnumerable<(SpellType Type, int Count)> GetSpellCountByType()
        {
            return wizards.SelectMany(w => w.SpellBook)
                         .Distinct()
                         .GroupBy(s => s.Type)
                         .Select(g => (g.Key, g.Count()));
        }

        // 12. Get spell count by type for specific wizard
        public IEnumerable<(SpellType Type, int Count)> GetSpellCountByTypeForWizard(string wizardName)
        {
            var wizard = wizards.Single(w => w.Name == wizardName);
            return wizard.SpellBook.GroupBy(s => s.Type)
                                  .Select(g => (g.Key, g.Count()));
        }

        // 13. Get most powerful wizards
        public IEnumerable<(string Name, int Level)> GetMostPowerfulWizards(int skip, int take)
        {
            return wizards.OrderByDescending(w => w.Level)
                         .ThenByDescending(w => w.Experience)
                         .Skip(skip)
                         .Take(take)
                         .Select(w => (w.Name, w.Level));
        }

        // 14. Check if all wizards are ready for tournament
        public bool AreAllWizardsReadyForTournament()
        {
            return wizards.All(w => w.CurrentHealth == w.MaxHealth && w.CurrentMana == w.MaxMana);
        }

        // 15. Check if any wizard is unconscious
        public bool IsAnyWizardUnconscious()
        {
            return wizards.Any(w => w.CurrentHealth == 0);
        }

        // 16. Get best wizards for special mission
        public IEnumerable<(string Name, int Level, int TotalResistance, int Physical, int Fire, int Frost, int Poison)> 
            GetBestWizardsForSpecialMission(int minLevel, int count)
        {
            return wizards.Where(w => w.Level > minLevel)
                         .Select(w => (
                             w.Name,
                             w.Level,
                             TotalResistance: w.PhysicalResistance + w.FireResistance + w.FrostResistance + w.PoisonResistance,
                             w.PhysicalResistance,
                             w.FireResistance,
                             w.FrostResistance,
                             w.PoisonResistance
                         ))
                         .OrderByDescending(x => x.TotalResistance)
                         .Take(count);
        }
    }
} 