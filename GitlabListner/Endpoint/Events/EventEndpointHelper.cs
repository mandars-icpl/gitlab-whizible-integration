namespace GitlabListner.Endpoint.Events
{
    public static class EventEndpointHelper
    {
        public static RouteGroupBuilder EventEndpoint(this RouteGroupBuilder builder)
        {
            builder.MapGet("/", () => Results.Ok("This endpoint handles webhook trigger events for different events such as issues, push , etc"));
            return builder;
        }
    }
}
