using System;

namespace GameCharacters
{
    public class Dragon : Character
    {
        public int ExperienceReward { get; set; }
        public event Action<int> OnFireBreath = delegate { };

        public Dragon(string name) : base()
        {
            Name = name;
            Strength = 20;
            Dexterity = 10;
            Intelligence = 15;
            MaxHealth = 200;
            CurrentHealth = MaxHealth;
            Damage = 25;
            DamageResistance = 10;
            ExperienceReward = 1000;
        }

        public int BreatheFire()
        {
            int fireIntensity = (Level * 5) + (Intelligence * 2);
            OnFireBreath?.Invoke(fireIntensity);
            return fireIntensity;
        }

        public override void LevelUp()
        {
            base.LevelUp();
            Strength += 4;
            Dexterity += 2;
            Intelligence += 3;
            MaxHealth += 50;
            CurrentHealth = MaxHealth;
            Damage += 5;
            DamageResistance += 2;
            ExperienceReward += 200;
        }
    }
}