using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameTrackerLibrary;

public class DuplicateGameException : Exception
{
    public DuplicateGameException(string title)
        : base($"Game already exists: {title}") { }
}
