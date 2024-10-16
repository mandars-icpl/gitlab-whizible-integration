using Gitlab.Infrastructure.Events.Issues;

public class IssueRepository : IIssueEventRepository
{
    public Task AddIssueToQueue(IssuesEvent issuesEvent, Dictionary<string, string> fields)
    {
        var updatedIssueEvent = issuesEvent;

        var issueInfoForWhizible = IssueMapper.MapToWzIssue(issuesEvent, fields);


        // Serialize the issue object
        var jsonString = CommonHelpers.FormatJsonString(issueInfoForWhizible, typeof(WzIssue)); // Use typeof(WzIssue)

        // Get the path of the Python scripts
        //string scriptPath = Environment.GetEnvironmentVariable("WHIZIBLE_PLAYWRIGHT_SCRIPT_PATH", EnvironmentVariableTarget.User) ?? "C:\\whizible-scripts\\";

        // Pass jsonString as an argument to the script and scriptPath as the working directory
        //ProcessHelpers.ExecuteScripts("python", $"{scriptPath}\\create_issue.py \"{jsonString}\"", scriptPath);

        var currentDirectory = Environment.CurrentDirectory;
        var whizibleUsername = Environment.GetEnvironmentVariable("WHIZIBLE-USERNAME");
        var whiziblePassword = Environment.GetEnvironmentVariable("WHIZIBLE-PASSWORD");

        ProcessHelpers.ExecuteScripts(Path.Combine(currentDirectory, "Scripts\\create_issue.exe"), $"\"{jsonString}\" {whizibleUsername} {whiziblePassword}");


        return Task.CompletedTask;
    }
}
