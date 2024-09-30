namespace Gitlab.Domain.Services;

public interface IIssueEventService
{
    Task AddIssueEvent(IssuesEvent issuesEvent);
    Task UpdateIssueEvent(IssuesEvent issuesEvent);
}
