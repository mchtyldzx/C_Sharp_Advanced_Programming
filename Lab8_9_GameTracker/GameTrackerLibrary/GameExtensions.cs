using System;
using System.Collections.Generic;
using System.Linq;

namespace GameTrackerLibrary;

public static class GameExtensions
{
    public static TimeSpan GetPlayTime(this Game game)
    {
        return game.EndDate?.Subtract(game.StartDate) ?? TimeSpan.Zero;
    }

    public static bool IsCompleted(this Game game)
    {
        return game.EndDate.HasValue;
    }

    public static IEnumerable<Game> GetTopRatedGames(this IEnumerable<Game> games, int count = 5)
    {
        return games.OrderByDescending(g => g.Rating).Take(count);
    }

    public static IEnumerable<Game> GetMostPlayedGames(this IEnumerable<Game> games, int count = 5)
    {
        return games.OrderByDescending(g => g.HoursPlayed).Take(count);
    }

    public static double GetAverageRating(this IEnumerable<Game> games)
    {
        return games.Any() ? games.Average(g => g.Rating) : 0;
    }

    public static Dictionary<GameType, int> GetGameTypeStatistics(this IEnumerable<Game> games)
    {
        return games
            .Where(g => g.Type != null)
            .GroupBy(g => g.Type!)
            .ToDictionary(g => g.Key, g => g.Count());
    }
} 