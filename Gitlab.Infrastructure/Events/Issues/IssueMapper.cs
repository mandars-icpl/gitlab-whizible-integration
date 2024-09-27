namespace Gitlab.Infrastructure.Events.Issues;

public static class IssueMapper
{
    public static WzIssue MapToWzIssue(IssuesEvent issuesEvent,Dictionary<string,string>fields)
    {
        return new WzIssue
        {
            ProjectName = issuesEvent.Project?.Name,
            Description = issuesEvent.ObjectAttributes?.Description,
            ReportedBy = issuesEvent.User?.Name,
            ReportedDate = issuesEvent.ObjectAttributes?.CreatedAt,
            ReportedTime = issuesEvent.ObjectAttributes?.CreatedAt,
            // check if key Status exists in fields if exists then get value
            Status = fields.ContainsKey("Status") ? fields["Status"] : null,
            Type = fields.ContainsKey("Type") ? fields["Type"] : "Defects",
            SubType = fields.ContainsKey("SubType") ? fields["SubType"] : null,
            Priority = fields.ContainsKey("Priority") ? fields["Priority"] : null,
            Severity = fields.ContainsKey("Severity") ? fields["Severity"] : null,
            ResponsiblePerson = issuesEvent.Assignees?.FirstOrDefault()?.Name,
            RootCause = fields.ContainsKey("RootCause") ? fields["RootCause"] : null
        };
    }
    
}
