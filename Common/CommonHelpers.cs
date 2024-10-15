using System.Text.Json;

namespace Common;

public static class CommonHelpers
{
    public static string? FormatJsonString(object objectToFormat, Type type)
    {
        if (objectToFormat == null)
        {
            return null;
        }

        if (type == null)
        {
            return null;
        }

        // Serialize the object using the provided type
        var jsonString = JsonSerializer.Serialize(objectToFormat, type);

        // Escape double quotes and remove newline characters
        jsonString = jsonString.Replace("\"", "\\\"");

        return jsonString;
    }
}
