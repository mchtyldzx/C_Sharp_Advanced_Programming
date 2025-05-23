using System;

namespace WarriorGuild
{
    public class Warrior
    {
        public string? Gender { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public string? Monster { get; set; }

        public Warrior()
        {
            // Default constructor
            Gender = "Male";
            Name = "";
            Level = 1;
            HP = 100;
            Monster = "";
        }

        public Warrior(string gender, string name, int level, int hp, string monster)
        {
            Gender = gender;
            Name = name;
            Level = level;
            HP = hp;
            Monster = monster;
        }

        public override string ToString()
        {
            return Name ?? "Unknown";
        }
    }
} 