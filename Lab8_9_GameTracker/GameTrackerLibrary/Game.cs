using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTrackerLibrary;

public class Game
{
    public string? Title { get; set; }
    public GameType? Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int HoursPlayed { get; set; }
    public double Rating { get; set; }
}

