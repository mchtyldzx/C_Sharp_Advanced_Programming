using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace GameTrackerLibrary;

public static class JsonPolymorphicSupport
{
    public static void Apply(JsonTypeInfo typeInfo)
    {
        if (typeInfo.Type == typeof(Game))
        {
            // Remove polymorphic configuration
            // typeInfo.PolymorphismOptions = new JsonPolymorphismOptions
            // {
            //     TypeDiscriminatorPropertyName = "$type",
            //     IgnoreUnrecognizedTypeDiscriminators = true,
            //     UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToBaseType,
            //     DerivedTypes =
            //     {
            //         // new JsonDerivedType(typeof(SinglePlayerGame), "single"),
            //         // new JsonDerivedType(typeof(MultiplayerGame), "multi")
            //     }
            // };
        }
    }
}
