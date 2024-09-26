using GitlabModels;

namespace GitlabListner.Endpoint.Events.Issues
{
    public class IssueEventHandler
    {
        public IResult Handler(IssuesEvent issuesEvent)
        {
            // print the object in json 
            Console.WriteLine("Issue recived");
            Console.WriteLine("Project Id of the proejct is : " + issuesEvent.ObjectAttributes?.ProjectId);
            Console.WriteLine("Issue Title " + issuesEvent.ObjectAttributes?.Title);
            return Results.Ok("Event Received");
        }
    }
}
