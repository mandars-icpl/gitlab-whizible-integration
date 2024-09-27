namespace Gitlab.Infrastructure.Events.Issues;

public class AddIssue
{
    public class IssueInfo
    {
        public required IssuesEvent IssuesEvent { get; set; }
    }

    public void AddIssueToQueue(IssueInfo issueInfo)
    {
        var issuesEvent = issueInfo.IssuesEvent;
        var labels = issuesEvent.Labels; // Assuming this is a list of label strings
        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
        foreach (var (key, value) in from label in labels
                                     let labelTitle = label.Title// Split into exactly 2 parts also remove whitespace in the key and value
                                     let parts = labelTitle.Split("-", 2).Select(x => x.Trim()).ToArray()
                                     where parts.Length == 2
                                     let key = parts[0]
                                     let value = parts[1]
                                     select (key, value))
        {
            // Try to add the key-value pair, and handle duplicates efficiently
            if (!keyValuePairs.ContainsKey(key))
            {
                keyValuePairs.Add(key, value);
            }
            else
            {
                Console.WriteLine($"Duplicate key {key} found in labels");
            }
        }

        var fields = keyValuePairs;
        var wzIssue = IssueMapper.MapToWzIssue(issuesEvent, fields);

        Console.WriteLine(wzIssue);
    }
}
