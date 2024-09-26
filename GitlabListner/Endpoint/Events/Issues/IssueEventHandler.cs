using GitlabModels;
using System.Text.Json;

namespace GitlabListner.Endpoint.Events.Issues
{
    public class IssueEventHandler
    {
        public IResult Handler(IssuesEvent issuesEvent)
        {
            // print the object in json 
            Console.WriteLine("Issue recived");
            // print json object issue event
            Console.WriteLine(JsonSerializer.Serialize(issuesEvent));
            return Results.Ok("Event Received");
        }
    }
}
