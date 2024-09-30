namespace Gitlab.Domain.Repositories;

public interface IIssueEventRepository
{
    Task AddIssueToQueue(IssuesEvent issuesEvent, Dictionary<string, string> fields);
}
