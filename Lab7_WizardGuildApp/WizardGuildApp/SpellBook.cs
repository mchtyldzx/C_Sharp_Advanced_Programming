using System;
using System.Collections.Generic;
using System.Linq;

namespace WizardGuildApp
{
    public class SpellBook : List<Spell>
    {
        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.Select(spell => spell.ToString()));
        }
    }
} 