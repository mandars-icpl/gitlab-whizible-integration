using Gitlab.Domain.Repositories.Issues;
using Gitlab.Domain.Services.Issues.Helpers;
using Gitlab.Models;

namespace Gitlab.Domain.Services.Issues;

public class IssueEventService(IIssueEventRepository issueEventRepository) : IIssueEventService
{
    public async Task AddIssueEvent(IssuesEvent issuesEvent)
    {
        var labelsField = issuesEvent.Labels ?? [];
        var labels = IssueHelpers.ProcessLabels(labelsField);

        await issueEventRepository.AddIssueToQueue(issuesEvent, labels);
    }

    public Task UpdateIssueEvent(IssuesEvent issuesEvent)
    {
        throw new NotImplementedException();
    }
}
