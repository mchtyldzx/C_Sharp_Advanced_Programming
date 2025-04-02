namespace MercenaryGuild.Library
{
    // Delegate for handling a mercenary
    public delegate void MercenaryHandler(Mercenary mercenary);
    
    // Delegate for handling a quest
    public delegate void QuestHandler(Quest quest);
    
    // Delegate for handling a mercenary and a quest together
    public delegate void MercenaryQuestHandler(Mercenary mercenary, Quest quest);
} 