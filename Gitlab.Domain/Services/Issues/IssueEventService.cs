namespace Gitlab.Domain.Services;

public class IssueEventService(IIssueEventRepository issueEventRepository) : IIssueEventService
{
    public async Task AddIssueEvent(IssuesEvent issuesEvent)
    {
        var labelsField = issuesEvent.Labels ?? [];
        var labels = IssueHelpers.ProcessLabels(labelsField);

        await issueEventRepository.AddIssueToQueue(issuesEvent, labels);
    }

    public async Task UpdateIssueEvent(IssuesEvent issuesEvent)
    {
        var labelsField = issuesEvent.Labels ?? [];
        var labels = IssueHelpers.ProcessLabels(labelsField);

        await issueEventRepository.AddIssueToQueue(issuesEvent, labels);
    }
}
