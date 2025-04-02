using System;
using System.Collections.Generic;
using System.Threading;
using MercenaryGuild.Library;

namespace MercenaryGuild.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mercenary Guild Management System";
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("========================================");
            Console.WriteLine("   MERCENARY GUILD MANAGEMENT SYSTEM   ");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Thread.Sleep(1000); // Wait for 1 second
            
            // Create a new guild
            Guild guild = new Guild();
            
            // Setup event handlers
            SetupEventHandlers(guild);
            Thread.Sleep(500); // Wait for 0.5 seconds
            
            // Create monsters
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCreating monsters for the quests...");
            Console.ResetColor();
            Thread.Sleep(700); // Wait for 0.7 seconds
            
            var rat = new Monster("Giant Rat", 20, 5);
            var wolf = new Monster("Dire Wolf", 40, 10);
            var troll = new Monster("Forest Troll", 80, 15);
            var dragon = new Monster("Young Dragon", 150, 25);
            Thread.Sleep(500); // Wait for 0.5 seconds
            
            // Create quests
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPreparing quests...");
            Console.ResetColor();
            Thread.Sleep(700); // Wait for 0.7 seconds
            
            var ratHuntQuest = new Quest(
                "Rat Hunt", 
                "Exterminate the giant rats in the sewers", 
                "Sewers", 
                Difficulty.Training, 
                rat, 
                50, 
                25);
                
            var wolfHuntQuest = new Quest(
                "Wolf Pack", 
                "Hunt down the wolves terrorizing local farmers", 
                "Forest", 
                Difficulty.Easy, 
                wolf, 
                100, 
                50);
                
            var trollHuntQuest = new Quest(
                "Troll Trouble", 
                "Eliminate the troll controlling the bridge", 
                "Forest", 
                Difficulty.NotSoEasy, 
                troll, 
                200, 
                100);
                
            var dragonHuntQuest = new Quest(
                "Dragon's Lair", 
                "Slay the young dragon in the mountain cave", 
                "Mountain", 
                Difficulty.Hard, 
                dragon, 
                500, 
                250);
            Thread.Sleep(500); // Wait for 0.5 seconds
            
            // Create mercenaries
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRecruiting mercenaries...");
            Console.ResetColor();
            Thread.Sleep(700); // Wait for 0.7 seconds
            
            var geralt = new Mercenary("Geralt", 5, 0, 100, 30, 100);
            var triss = new Mercenary("Triss", 4, 0, 80, 25, 75);
            var vesemir = new Mercenary("Vesemir", 10, 0, 150, 40, 200);
            Thread.Sleep(500); // Wait for 0.5 seconds
            
            try
            {
                // Add quests to the guild
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Adding Quests to the Guild ===");
                Console.ResetColor();
                Thread.Sleep(500); // Wait for 0.5 seconds
                
                guild.AddQuest(ratHuntQuest);
                guild.AddQuest(wolfHuntQuest);
                guild.AddQuest(trollHuntQuest);
                guild.AddQuest(dragonHuntQuest);
                
                // Add mercenaries to the guild
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Hiring Mercenaries ===");
                Console.ResetColor();
                Thread.Sleep(500); // Wait for 0.5 seconds
                
                guild.HireMercenary(geralt);
                guild.HireMercenary(triss);
                guild.HireMercenary(vesemir);
                
                // Try to add duplicate (should throw exception)
                // Uncomment to test exception handling
                // guild.HireMercenary(new Mercenary("Geralt", 1, 0, 50, 10, 50));
                
                // Test the ForEachMercenary method
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Guild Mercenaries ===");
                Console.ResetColor();
                Thread.Sleep(500); // Wait for 0.5 seconds
                
                guild.ForEachMercenary(mercenary => {
                    Console.WriteLine($"- {mercenary}");
                });
                
                // Test the ForEachQuest method
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Available Quests ===");
                Console.ResetColor();
                Thread.Sleep(500); // Wait for 0.5 seconds
                
                guild.ForEachQuest(quest => {
                    Console.WriteLine($"- {quest}");
                });
                
                // Test finding mercenaries and quests
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Finding Mercenaries and Quests ===");
                Console.ResetColor();
                Thread.Sleep(500); // Wait for 0.5 seconds
                
                Console.WriteLine("Mercenary 'Geralt': " + guild.FindMercenaryByName("Geralt"));
                Thread.Sleep(400); // Wait for 0.4 seconds
                
                Console.WriteLine("Mercenaries with level > 4 or max health > 100:");
                Thread.Sleep(400); // Wait for 0.4 seconds
                
                var highLevelMercenaries = guild.FindMercenaries(4, 100);
                foreach (var merc in highLevelMercenaries)
                {
                    Console.WriteLine($"- {merc}");
                    Thread.Sleep(300); // Wait for 0.3 seconds
                }
                
                Console.WriteLine("\nQuest 'Wolf Pack': " + guild.FindQuestByName("Wolf Pack"));
                Thread.Sleep(400); // Wait for 0.4 seconds
                
                Console.WriteLine("Quests in the Forest with difficulty NotSoEasy:");
                Thread.Sleep(400); // Wait for 0.4 seconds
                
                var forestQuests = guild.FindQuests("Forest", Difficulty.NotSoEasy);
                foreach (var quest in forestQuests)
                {
                    Console.WriteLine($"- {quest}");
                    Thread.Sleep(300); // Wait for 0.3 seconds
                }
                
                // Send mercenaries on quests
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Sending Mercenaries on Quests ===");
                Console.ResetColor();
                Thread.Sleep(700); // Wait for 0.7 seconds
                
                Console.WriteLine("\nSending Geralt on Rat Hunt quest...");
                Thread.Sleep(500); // Wait for 0.5 seconds
                guild.SendMercenaryOnQuest("Geralt", "Rat Hunt");
                
                Console.WriteLine("\nSending Triss on Wolf Pack quest...");
                Thread.Sleep(500); // Wait for 0.5 seconds
                guild.SendMercenaryOnQuest("Triss", "Wolf Pack");
                
                Console.WriteLine("\nSending Vesemir on Dragon's Lair quest...");
                Thread.Sleep(500); // Wait for 0.5 seconds
                guild.SendMercenaryOnQuest("Vesemir", "Dragon's Lair");
                
                // Show final status
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=== Final Status of Mercenaries ===");
                Console.ResetColor();
                Thread.Sleep(700); // Wait for 0.7 seconds
                
                guild.ForEachMercenary(mercenary => {
                    Console.WriteLine($"- {mercenary}");
                });
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n========================================");
            Console.WriteLine("            END OF SIMULATION           ");
            Console.WriteLine("========================================");
            Console.ResetColor();
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static void SetupEventHandlers(Guild guild)
        {
            // Set up event handlers for guild events
            guild.OnMercenaryHired += mercenary => 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"EVENT: The guild has hired {mercenary.Name} at level {mercenary.Level}!");
                Console.ResetColor();
            };
            
            guild.OnQuestAdded += quest => 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"EVENT: New quest '{quest.Name}' has been posted on the guild board!");
                Console.ResetColor();
            };
            
            guild.OnQuestCompleting += (mercenary, quest) => 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"EVENT: {mercenary.Name} is preparing to take on quest '{quest.Name}'...");
                
                // Example of custom pre-quest logic
                if (quest.Difficulty == Difficulty.Hard || quest.Difficulty == Difficulty.VeryHard || quest.Difficulty == Difficulty.NightmarishlyHard)
                {
                    Console.WriteLine($"EVENT: The guild provides {mercenary.Name} with a health potion for the difficult quest!");
                    mercenary.MaxHealth += 20;
                    mercenary.CurrentHealth += 20;
                }
                
                Console.ResetColor();
            };
            
            guild.OnQuestCompleted += (mercenary, quest) => 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"EVENT: {mercenary.Name} has returned from quest '{quest.Name}'.");
                
                // Example of custom post-quest logic
                if (mercenary.CurrentHealth < mercenary.MaxHealth / 2)
                {
                    int healing = mercenary.MaxHealth / 4;
                    mercenary.CurrentHealth += healing;
                    Console.WriteLine($"EVENT: The guild healers restore {healing} health to {mercenary.Name}.");
                }
                
                Console.ResetColor();
            };
        }
    }
} 