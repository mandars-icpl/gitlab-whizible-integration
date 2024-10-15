namespace Gitlab.Infrastructure.Helpers;

internal static class InfraHelpers
{
    public static string GetWhiziblePlaywrightScriptPath()
    {
        string WhiziblePlaywrightScriptPath = Environment.GetEnvironmentVariable("WHIZIBLE_PLAYWRIGHT_SCRIPT_PATH", EnvironmentVariableTarget.User) ?? "C:\\whizible-scripts\\";
        return WhiziblePlaywrightScriptPath;
    }

}
