using GitlabModels;

namespace GitlabListner.Endpoint.Events.Issues
{
    public class IssueEventListner
    {
        public IResult Handler(IssuesEvent issuesEvent)
        {
            // print the object in json 
            Console.WriteLine("Issue received");
            // print json object issue event
            //Console.WriteLine(JsonSerializer.Serialize(issuesEvent));
            var issueId = issuesEvent.ObjectAttributes?.Id;
            var projectId = issuesEvent.ObjectAttributes?.ProjectId;

            // if project has clean achitecture then the switch case below is valid in this file or should be somwhere else ? 



            switch (issuesEvent.ObjectAttributes?.Action)
            {
                case "open":
                    Console.WriteLine($"Issue ${issueId} of project ${projectId} Opened");
                    break;
                case "close":
                    Console.WriteLine($"Issue ${issueId} of project ${projectId} Closed");
                    break;
                case "update":
                    Console.WriteLine($"Issue ${issueId} of project ${projectId} Updated");
                    CheckIfLabelsAreUpdated(issuesEvent);
                    break;
                case "reopen":
                    Console.WriteLine($"Issue ${issueId} of project ${projectId} Reopened");
                    break;
                default:
                    break;
            }
            bool CheckIfLabelsAreUpdated(IssuesEvent issuesEvent)
            {
                var changes = issuesEvent.Changes;
                // if changes.Labels is not null or [] then log labels changed
                if (changes?.Labels?.Current != null)
                {
                    Console.WriteLine($"Labels changed from {changes.Labels.Previous} to {changes.Labels.Current}");
                    Console.WriteLine(string.Join(",", changes.Labels.Current.Select(x => x.Title)));

                    return true;
                }


                return false;
            }
            return Results.Ok("Event Received");
        }


    }
}
