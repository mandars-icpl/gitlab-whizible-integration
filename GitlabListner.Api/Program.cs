using GitlabListner;
using GitlabListner.Endpoint.Events;
using GitlabListner.Endpoint.Events.Issues;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = AppJsonSerializerContext.Default;
});

builder.Services.AddSingleton<IssueEventListner>();

// fetch the secret key from the environment
var secret = Environment.GetEnvironmentVariable("GITLAB-TOKEN");

var app = builder.Build();

app.UseMiddleware<ApiAuth.GitlabSecretKeyCheck>(secret);
app.MapGroup("/api/events").EventEndpoint();
app.MapGet("/", () => "Hello World!");
app.Run();


