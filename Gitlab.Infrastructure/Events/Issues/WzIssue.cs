namespace Gitlab.Infrastructure.Events.Issues
{
    public class WzIssue
    {
        public required string ProjectName { get; set; }

        public required string Summary { get; set; }

        public required string Description { get; set; }

        public required string ReportedBy { get; set; }

        public required string ReportedDate { get; set; }

        public required string ReportedTime { get; set; }

        // Status : Discussion and New
        public required string Status { get; set; }

        // Type : Defects
        public required string Type { get; set; }

        // Subtype : Change Request, Defects, Existing in Production
        public required string SubType { get; set; }

        // Priority : High, Immediate, Urgent, Normal, Immediate
        public string? Priority { get; set; }

        // Severity : Block, Crash, Feature, Major, Minor, Text, Trivial, Tweak
        public required string Severity { get; set; }

        public required string ResponsiblePerson { get; set; }

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
        public required string RootCause { get; set; }

    }
}
