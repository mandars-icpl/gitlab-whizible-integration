using Gitlab.Domain.Repositories.Issues;
using Gitlab.Models;

namespace Gitlab.Domain.Services.Issues;

public class IssueEventService : IIssueEventService
{
    private readonly IIssueEventRepository _issueEventRepository;

    public IssueEventService(IIssueEventRepository issueEventRepository)
    {
        _issueEventRepository = issueEventRepository;
    }

    public async Task AddIssueEvent(IssuesEvent issuesEvent)
    {
        var labels = issuesEvent.Labels;
        Dictionary<string, string> fields = new Dictionary<string, string>();
        foreach (var (key, value) in from label in labels
                                     let labelTitle = label.Title
                                     let parts = labelTitle.Split("-", 2).Select(x => x.Trim()).ToArray()
                                     where parts.Length == 2
                                     let key = parts[0]
                                     let value = parts[1]
                                     select (key, value))
        {
            if (!fields.ContainsKey(key))
            {
                fields.Add(key, value);
            }
            else
            {
                Console.WriteLine($"Duplicate key {key} found in labels");
            }
        }
        await _issueEventRepository.AddIssueToQueue(issuesEvent, fields);
    }

    public Task UpdateIssueEvent(IssuesEvent issuesEvent)
    {
        throw new NotImplementedException();
    }
}
