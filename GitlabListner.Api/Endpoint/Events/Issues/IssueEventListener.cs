namespace GitlabListener.Endpoint.Events.Issues;

public class IssueEventListener
{

    private readonly IIssueEventService _issueEventService;

    public IssueEventListener(IIssueEventService issueEventService)
    {
        _issueEventService = issueEventService;
    }

    public async Task<IResult> Handler(IssuesEvent issuesEvent)
    {
        Console.WriteLine("Issue received");
        var issueId = issuesEvent.ObjectAttributes?.Id;
        var projectId = issuesEvent.ObjectAttributes?.ProjectId;

        // action open (new issue created), close (issue closed), update (issue updated), reopen (issue reopened)
        var actionPerformed = issuesEvent.ObjectAttributes?.Action;
        switch (actionPerformed)
        {
            case "open":
                Console.WriteLine($"Issue {issueId} of project {projectId} Opened");
                await _issueEventService.AddIssueEvent(issuesEvent);
                break;
            case "close":
                Console.WriteLine($"Issue {issueId} of project {projectId} Closed");
                break;
            case "update":
                Console.WriteLine($"Issue {issueId} of project {projectId} Updated");
                await _issueEventService.UpdateIssueEvent(issuesEvent);
                break;
            case "reopen":
                Console.WriteLine($"Issue {issueId} of project {projectId} Reopened");
                break;
            default:
                break;
        }
        return Results.Ok("Event Received");
    }
}
