namespace Gitlab.Domain.Services;

internal static class IssueHelpers
{
    public static Dictionary<string, string> ProcessLabels(IEnumerable<Label> labels)
    {
        var keyValuePairs = new Dictionary<string, string>();

        foreach (var label in labels)
        {
            var parts = label.Title.Split('-', 2).Select(x => x.Trim()).ToArray();

            if (parts.Length == 2)
            {
                var key = parts[0];
                var value = parts[1];

                if (!keyValuePairs.TryAdd(key, value))
                {
                    Console.WriteLine($"Duplicate key '{key}' found in labels. Overwriting value.");
                    keyValuePairs[key] = value; // Overwrite the value if needed.
                }
            }
        }

        return keyValuePairs;
    }
}
