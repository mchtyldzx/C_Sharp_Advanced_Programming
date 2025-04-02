using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MercenaryGuild.Library
{
    public class Guild
    {
        private List<Mercenary> _mercenaries;
        private List<Quest> _quests;

        // Events
        public event MercenaryHandler OnMercenaryHired;
        public event QuestHandler OnQuestAdded;
        public event MercenaryQuestHandler OnQuestCompleting;
        public event MercenaryQuestHandler OnQuestCompleted;

        public Guild()
        {
            _mercenaries = new List<Mercenary>();
            _quests = new List<Quest>();
        }

        // Method to hire a mercenary
        public void HireMercenary(Mercenary mercenary)
        {
            // Check if a mercenary with this name already exists
            if (_mercenaries.Any(m => m.Name == mercenary.Name))
            {
                throw new DuplicateMercenaryNameException($"A mercenary named '{mercenary.Name}' already exists in the guild.");
            }

            _mercenaries.Add(mercenary);
            Thread.Sleep(500); // Wait for 0.5 second
            
            // Trigger event after hiring
            OnMercenaryHired?.Invoke(mercenary);
            Thread.Sleep(700); // Wait for 0.7 seconds
        }

        // Method to add a new quest
        public void AddQuest(Quest quest)
        {
            // Check if a quest with this name already exists
            if (_quests.Any(q => q.Name == quest.Name))
            {
                throw new DuplicateQuestNameException($"A quest named '{quest.Name}' already exists in the guild.");
            }

            _quests.Add(quest);
            Thread.Sleep(500); // Wait for 0.5 second
            
            // Trigger event after adding
            OnQuestAdded?.Invoke(quest);
            Thread.Sleep(700); // Wait for 0.7 seconds
        }

        // Method to send a mercenary on a quest
        public void SendMercenaryOnQuest(string mercenaryName, string questName)
        {
            // Find the mercenary
            var mercenary = _mercenaries.Find(m => m.Name == mercenaryName);
            if (mercenary == null)
            {
                throw new MercenaryNotFoundException($"Could not find a mercenary named '{mercenaryName}'.");
            }

            // Find the quest
            var quest = _quests.Find(q => q.Name == questName);
            if (quest == null)
            {
                throw new QuestNotFoundException($"Could not find a quest named '{questName}'.");
            }

            // Trigger event before completing the quest
            OnQuestCompleting?.Invoke(mercenary, quest);
            Thread.Sleep(700); // Wait for 0.7 seconds

            // Simulate the quest
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{mercenary.Name} is embarking on the quest: {quest.Name}");
            Thread.Sleep(700); // Wait for 0.7 seconds
            
            Console.WriteLine($"Location: {quest.Location}");
            Thread.Sleep(400); // Wait for 0.4 seconds
            
            Console.WriteLine($"Difficulty: {quest.Difficulty}");
            Thread.Sleep(400); // Wait for 0.4 seconds
            
            Console.WriteLine($"Monster: {quest.Monster.Name}");
            Thread.Sleep(700); // Wait for 0.7 seconds
            Console.ResetColor();

            // Calculate damage taken
            int damageToMercenary = quest.Monster.Damage;
            mercenary.CurrentHealth -= damageToMercenary;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{mercenary.Name} took {damageToMercenary} damage from {quest.Monster.Name}!");
            Thread.Sleep(700); // Wait for 0.7 seconds
            
            Console.WriteLine($"{mercenary.Name}'s health: {mercenary.CurrentHealth}/{mercenary.MaxHealth}");
            Thread.Sleep(600); // Wait for 0.6 seconds
            Console.ResetColor();

            // Check if mercenary survived
            if (mercenary.CurrentHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{mercenary.Name} has been defeated by {quest.Monster.Name}!");
                Thread.Sleep(800); // Wait for 0.8 seconds
                
                Console.WriteLine("The quest has failed.");
                Thread.Sleep(1000); // Wait for 1 second
                Console.ResetColor();
                
                // Restore some health after failure
                mercenary.CurrentHealth = mercenary.MaxHealth / 4;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{mercenary.Name} has been rescued and restored to {mercenary.CurrentHealth} health.");
                Thread.Sleep(800); // Wait for 0.8 seconds
                Console.ResetColor();
                
                // Trigger event after completing the quest (unsuccessfully)
                OnQuestCompleted?.Invoke(mercenary, quest);
                Thread.Sleep(700); // Wait for 0.7 seconds
                return;
            }

            // Calculate damage to monster
            int damageToMonster = mercenary.Damage;
            int monsterRemainingHealth = quest.Monster.Health - damageToMonster;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{mercenary.Name} dealt {damageToMonster} damage to {quest.Monster.Name}!");
            Thread.Sleep(700); // Wait for 0.7 seconds
            
            Console.WriteLine($"{quest.Monster.Name}'s health: {monsterRemainingHealth}/{quest.Monster.Health}");
            Thread.Sleep(600); // Wait for 0.6 seconds
            Console.ResetColor();

            // If monster defeated, reward the mercenary
            if (monsterRemainingHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{mercenary.Name} has defeated {quest.Monster.Name}!");
                Thread.Sleep(800); // Wait for 0.8 seconds
                
                Console.WriteLine("The quest has been completed successfully!");
                Thread.Sleep(1000); // Wait for 1 second
                Console.ResetColor();

                // Award experience and gold
                mercenary.ExperiencePoints += quest.ExperienceReward;
                mercenary.GoldCoins += quest.GoldReward;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{mercenary.Name} gained {quest.ExperienceReward} experience points and {quest.GoldReward} gold coins!");
                Thread.Sleep(800); // Wait for 0.8 seconds
                Console.ResetColor();

                // Level up if enough XP (simple formula: 100 * level)
                if (mercenary.ExperiencePoints >= mercenary.Level * 100)
                {
                    mercenary.Level++;
                    mercenary.MaxHealth += 10;
                    mercenary.CurrentHealth = mercenary.MaxHealth;
                    mercenary.Damage += 5;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{mercenary.Name} has leveled up to level {mercenary.Level}!");
                    Thread.Sleep(700); // Wait for 0.7 seconds
                    
                    Console.WriteLine($"Max health increased to {mercenary.MaxHealth}");
                    Thread.Sleep(500); // Wait for 0.5 second
                    
                    Console.WriteLine($"Damage increased to {mercenary.Damage}");
                    Thread.Sleep(500); // Wait for 0.5 second
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{mercenary.Name} couldn't defeat {quest.Monster.Name}!");
                Thread.Sleep(800); // Wait for 0.8 seconds
                
                Console.WriteLine("The quest has failed.");
                Thread.Sleep(1000); // Wait for 1 second
                Console.ResetColor();
            }

            // Trigger event after completing the quest
            OnQuestCompleted?.Invoke(mercenary, quest);
            Thread.Sleep(700); // Wait for 0.7 seconds
        }

        // Method to perform an action on each mercenary
        public void ForEachMercenary(MercenaryHandler action)
        {
            foreach (var mercenary in _mercenaries)
            {
                action(mercenary);
                Thread.Sleep(300); // Wait for 0.3 seconds between each mercenary
            }
        }

        // Method to perform an action on each quest
        public void ForEachQuest(QuestHandler action)
        {
            foreach (var quest in _quests)
            {
                action(quest);
                Thread.Sleep(300); // Wait for 0.3 seconds between each quest
            }
        }

        // Find mercenary by name
        public Mercenary FindMercenaryByName(string name)
        {
            Thread.Sleep(250); // Wait for 0.25 seconds
            return _mercenaries.Find(m => m.Name == name);
        }

        // Find mercenaries by level or max health
        public List<Mercenary> FindMercenaries(int minLevel, int minMaxHealth)
        {
            Thread.Sleep(250); // Wait for 0.25 seconds
            return _mercenaries.FindAll(m => m.Level > minLevel || m.MaxHealth > minMaxHealth);
        }

        // Find quest by name
        public Quest FindQuestByName(string name)
        {
            Thread.Sleep(250); // Wait for 0.25 seconds
            return _quests.Find(q => q.Name == name);
        }

        // Find quests by location and difficulty
        public List<Quest> FindQuests(string location, Difficulty difficulty)
        {
            Thread.Sleep(250); // Wait for 0.25 seconds
            return _quests.FindAll(q => q.Location == location && q.Difficulty == difficulty);
        }
    }
} 