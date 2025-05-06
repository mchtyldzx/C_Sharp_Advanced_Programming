using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace GameTrackerLibrary;

public class GameTypeConverter : JsonConverter<GameType>
{
    public override GameType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? typeName = null;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                string propertyName = reader.GetString()!;
                reader.Read();

                if (propertyName == "TypeName")
                {
                    typeName = reader.GetString();
                }
            }
        }

        if (string.IsNullOrEmpty(typeName))
        {
            throw new JsonException("TypeName not found in JSON");
        }

        return typeName switch
        {
            "RPG" => new RPGGame(),
            "FPS" => new FPSGame(),
            "Strategy" => new StrategyGame(),
            _ => new CustomGameType(typeName)
        };
    }

    public override void Write(Utf8JsonWriter writer, GameType value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("TypeName", value.TypeName);
        writer.WriteEndObject();
    }
}

public static class GameStorage
{
    private static readonly JsonSerializerOptions options = new()
    {
        WriteIndented = true,
        Converters =
        {
            new JsonStringEnumConverter(),
            new GameTypeConverter()
        }
    };

    public static void Save(List<Game> games, string path)
    {
        string json = JsonSerializer.Serialize(games, options);
        File.WriteAllText(path, json);
    }

    public static List<Game> Load(string path)
    {
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Game>>(json, options)!;
    }
}
