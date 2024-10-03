using System.Text.Json.Serialization.Metadata;
using System.Text.Json;

namespace Common;

public static class CommonHelpers
{
    public static string FormatJsonString(object objectToFormat, JsonTypeInfo jsonTypeInfo)
    {
        // Serialize the issue object
        var jsonString = JsonSerializer.Serialize(objectToFormat, jsonTypeInfo);

        // Escape double quotes and remove newline characters
        jsonString = jsonString.Replace("\"", "\\\"");

        return jsonString;
    }

}
