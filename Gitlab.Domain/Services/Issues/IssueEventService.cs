namespace Gitlab.Domain.Services;

public class IssueEventService : IIssueEventService
{
    private readonly IIssueEventRepository issueEventRepository;

    public IssueEventService(IIssueEventRepository issueEventRepository)
    {
        this.issueEventRepository = issueEventRepository;
    }
    public async Task AddIssueEvent(IssuesEvent issuesEvent)
    {
        var labelsField = issuesEvent.Labels ?? new List<Label>();
        var labels = IssueHelpers.ProcessLabels(labelsField);

        await issueEventRepository.AddIssueToQueue(issuesEvent, labels);
    }

    public async Task UpdateIssueEvent(IssuesEvent issuesEvent)
    {
        var labelsField = issuesEvent.Labels ?? new List<Label>();
        var labels = IssueHelpers.ProcessLabels(labelsField);

        await issueEventRepository.AddIssueToQueue(issuesEvent, labels);
    }
}
