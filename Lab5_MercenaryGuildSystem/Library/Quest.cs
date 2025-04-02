namespace MercenaryGuild.Library
{
    public class Quest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Difficulty Difficulty { get; set; }
        public Monster Monster { get; set; }
        public int ExperienceReward { get; set; }
        public int GoldReward { get; set; }

        public Quest()
        {
        }

        public Quest(string name, string description, string location, 
                    Difficulty difficulty, Monster monster, 
                    int experienceReward, int goldReward)
        {
            Name = name;
            Description = description;
            Location = location;
            Difficulty = difficulty;
            Monster = monster;
            ExperienceReward = experienceReward;
            GoldReward = goldReward;
        }

        public override string ToString()
        {
            return $"Quest: {Name}, Location: {Location}, Difficulty: {Difficulty}, " +
                   $"Monster: {Monster.Name}, Rewards: {ExperienceReward} XP, {GoldReward} gold";
        }
    }
} 