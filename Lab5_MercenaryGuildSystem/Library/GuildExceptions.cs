using System;

namespace MercenaryGuild.Library
{
    public class DuplicateMercenaryNameException : Exception
    {
        public DuplicateMercenaryNameException() : base("A mercenary with this name already exists in the guild.")
        {
        }

        public DuplicateMercenaryNameException(string message) : base(message)
        {
        }

        public DuplicateMercenaryNameException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    public class DuplicateQuestNameException : Exception
    {
        public DuplicateQuestNameException() : base("A quest with this name already exists in the guild.")
        {
        }

        public DuplicateQuestNameException(string message) : base(message)
        {
        }

        public DuplicateQuestNameException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    public class MercenaryNotFoundException : Exception
    {
        public MercenaryNotFoundException() : base("Could not find a mercenary with that name.")
        {
        }

        public MercenaryNotFoundException(string message) : base(message)
        {
        }

        public MercenaryNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    public class QuestNotFoundException : Exception
    {
        public QuestNotFoundException() : base("Could not find a quest with that name.")
        {
        }

        public QuestNotFoundException(string message) : base(message)
        {
        }

        public QuestNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
} 