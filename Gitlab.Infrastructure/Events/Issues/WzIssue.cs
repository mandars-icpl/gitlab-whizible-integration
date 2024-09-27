namespace Gitlab.Infrastructure.Events.Issues;

public class WzIssue : IWModel
{
    public string? ProjectName { get; set; }

    public string? Summary { get; set; }

    public string? Description { get; set; }

    public string? ReportedBy { get; set; }

    public string? ReportedDate { get; set; }

    public string? ReportedTime { get; set; }

    // Status : Discussion and New
    public string? Status { get; set; }

    // Type : Defects
    public string? Type { get; set; }

    // Subtype : Change Request, Defects, Existing in Production
    public string? SubType { get; set; }

    // Priority : High, Immediate, Urgent, Normal, Immediate
    public string? Priority { get; set; }

    // Severity : Block, Crash, Feature, Major, Minor, Text, Trivial, Tweak
    public string? Severity { get; set; }

    public string? ResponsiblePerson { get; set; }

    /* Root Cause 
        Data Issue
    Database Integrity
    Duplicate
    Enhancement
    Impact Not Analyzed
    Improper Environment
    Improper Representative Data
    Incomplete Or Lack Of Specification
    Insufficient Testing
    Lack Of Domain Knowledge
    Lack of Regression Testing
    Lack of Review
    Oversight
    Program Or MethodBug
    Version Issue
     */
    public string? RootCause { get; set; }

}
