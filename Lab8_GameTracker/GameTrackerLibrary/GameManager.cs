using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrackerLibrary;

public delegate void GameCompletedHandler(Game game);

public class GameManager
{
    public event GameCompletedHandler? OnGameCompleted;

    private readonly List<Game> games = new();

    public void AddGame(Game game)
    {
        if (games.Any(g => g.Title == game.Title))
            throw new DuplicateGameException(game.Title!);
        
        games.Add(game);

        if (game.IsCompleted())
            OnGameCompleted?.Invoke(game);
    }

    public List<Game> GetAllGames() => games;

    public Dictionary<GameType, int> GetGameTypeStatistics()
    {
        return games.GetGameTypeStatistics();
    }

    public IEnumerable<Game> GetGamesByType(GameType type)
    {
        return games.Where(g => g.Type?.TypeName == type.TypeName);
    }

    public IEnumerable<Game> GetCompletedGames()
    {
        return games.Where(g => g.IsCompleted());
    }

    public IEnumerable<Game> GetGamesInProgress()
    {
        return games.Where(g => !g.IsCompleted());
    }

    public double GetTotalPlaytime()
    {
        return games.Sum(g => g.HoursPlayed);
    }

    public double GetAverageCompletionTime()
    {
        var completedGames = GetCompletedGames().ToList();
        return completedGames.Any() ? completedGames.Average(g => g.HoursPlayed) : 0;
    }

    public void RemoveGame(string title)
    {
        var game = games.FirstOrDefault(g => g.Title == title);
        if (game != null)
            games.Remove(game);
    }

    public void UpdateGame(Game game)
    {
        var existingGame = games.FirstOrDefault(g => g.Title == game.Title);
        if (existingGame != null)
        {
            var index = games.IndexOf(existingGame);
            games[index] = game;

            if (game.IsCompleted() && !existingGame.IsCompleted())
                OnGameCompleted?.Invoke(game);
        }
    }

    public Dictionary<string, int> CountByType()
    {
        return games
            .Where(g => g.Type != null)
            .GroupBy(g => g.Type!.TypeName)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}
