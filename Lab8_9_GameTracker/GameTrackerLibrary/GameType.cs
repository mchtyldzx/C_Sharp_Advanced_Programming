using System;

namespace GameTrackerLibrary;

public abstract class GameType
{
    public abstract string TypeName { get; }
    
    public override string ToString()
    {
        return TypeName;
    }
}

public class RPGGame : GameType
{
    public override string TypeName => "RPG";
}

public class FPSGame : GameType
{
    public override string TypeName => "FPS";
}

public class StrategyGame : GameType
{
    public override string TypeName => "Strategy";
}

public class CustomGameType : GameType
{
    private readonly string typeName;

    public CustomGameType(string typeName)
    {
        this.typeName = typeName;
    }

    public override string TypeName => typeName;
} 