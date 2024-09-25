using GitlabListner.Endpoint.Events.Issues;
using GitlabModels;

namespace GitlabListner.Endpoint.Events;

public static class EventEndpointHelper
{
    public static RouteGroupBuilder EventEndpoint(this RouteGroupBuilder builder)
    {
        builder.MapGet("/", static () => Results.Ok("This endpoint handles webhook trigger events for different events such as issues, push , etc"));
        builder.MapPost("/issues/", (IssueEventHandler handler, IssuesEvent issuesEvent) => handler.Handler(issuesEvent));
        return builder;
    }
}
