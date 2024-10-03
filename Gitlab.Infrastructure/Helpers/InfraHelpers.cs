using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Gitlab.Infrastructure.Helpers;

internal static class InfraHelpers
{
    public static string GetWhiziblePlaywrightScriptPath()
    {
        string WhiziblePlaywrightScriptPath = Environment.GetEnvironmentVariable("WHIZIBLE_PLAYWRIGHT_SCRIPT_PATH", EnvironmentVariableTarget.User) ?? "C:\\whizible-scripts\\";
        return WhiziblePlaywrightScriptPath;
    }
    public static string FormatJsonString(object objectToFormat, JsonTypeInfo jsonTypeInfo)
    {
        // Serialize the issue object
        var jsonString = JsonSerializer.Serialize(objectToFormat, jsonTypeInfo);

        // Escape double quotes and remove newline characters
        jsonString = jsonString.Replace("\"", "\\\"");

        return jsonString;
    }

}
