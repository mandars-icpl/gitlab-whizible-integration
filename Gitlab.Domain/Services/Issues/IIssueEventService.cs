namespace Gitlab.Domain.Services.Issues;

internal interface IIssueEventService
{
    Task AddIssueEvent(IssuesEvent issuesEvent);
    Task UpdateIssueEvent(IssuesEvent issuesEvent);
}
