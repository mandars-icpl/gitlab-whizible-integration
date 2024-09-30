namespace Gitlab.Domain.Repositories.Issues;

public interface IIssueEventRepository
{
    Task AddIssueToQueue(IssuesEvent issuesEvent, Dictionary<string, string> fields);
}
