namespace GitlabListener.Endpoint.Events.Issues;

public class IssueEventListener()
{
    public IResult Handler(IssuesEvent issuesEvent)
    {
        // print the object in json 
        Console.WriteLine("Issue received");
        var issueId = issuesEvent.ObjectAttributes?.Id;
        var projectId = issuesEvent.ObjectAttributes?.ProjectId;

        switch (issuesEvent.ObjectAttributes?.Action)
        {
            case "open":
                Console.WriteLine($"Issue {issueId} of project {projectId} Opened");
                break;
            case "close":
                Console.WriteLine($"Issue {issueId} of project {projectId} Closed");
                break;
            case "update":
                Console.WriteLine($"Issue {issueId} of project {projectId} Updated");
                if (CheckIfLabelsAreUpdated(issuesEvent))
                {
                    DisplayChangedValues(issuesEvent);
                }
                break;
            case "reopen":
                Console.WriteLine($"Issue {issueId} of project {projectId} Reopened");
                break;
            default:
                break;
        }
        bool CheckIfLabelsAreUpdated(IssuesEvent issuesEvent)
        {
            var changes = issuesEvent.Changes;
            // if changes.Labels is not null or [] then log labels changed
            if (changes?.Labels?.Current != null)
            {
                Console.WriteLine($"Labels changed from {changes.Labels.Previous} to {changes.Labels.Current}");
                Console.WriteLine(string.Join(",", changes.Labels.Current.Select(x => x.Title)));

                return true;
            }
            return false;
        }
        void DisplayChangedValues(IssuesEvent issuesEvent)
        {
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
        }
        return Results.Ok("Event Received");
    }


}
