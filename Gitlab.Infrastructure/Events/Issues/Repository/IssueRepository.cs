using Gitlab.Infrastructure.Events.Issues;

public class IssueRepository : IIssueEventRepository
{
    public Task AddIssueToQueue(IssuesEvent issuesEvent, Dictionary<string, string> fields)
    {
        var issueInfoForWhizible = IssueMapper.MapToWzIssue(issuesEvent, fields);
        Console.WriteLine(issueInfoForWhizible);
        return Task.CompletedTask;
    }
}
