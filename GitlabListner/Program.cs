using GitlabListner;
using GitlabListner.Endpoint.Events;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = AppJsonSerializerContext.Default;
});

var app = builder.Build();
app.MapGroup("/api/events").EventEndpoint();
app.MapGet("/", () => "Hello World!");
app.Run();


