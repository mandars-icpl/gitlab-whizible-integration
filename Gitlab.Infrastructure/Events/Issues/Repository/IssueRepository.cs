
using Gitlab.Domain.Repositories;

public class IssueRepository : IIssueEventRepository
{
    public Task AddIssueToQueue(IssuesEvent issuesEvent, Dictionary<string, string> fields)
    {
        throw new NotImplementedException();
    }
}
