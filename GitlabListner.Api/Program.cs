
using Gitlab.Infrastructure;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = AppJsonSerializerContext.Default;
});

builder.Services.AddGitlabInfrastructure();
builder.Services.AddTransient<IssueEventListener>();

// fetch the secret key from the environment
var secret = Environment.GetEnvironmentVariable("GITLAB-TOKEN");

var app = builder.Build();

app.UseMiddleware<ApiAuth.GitlabSecretKeyCheck>(secret);
app.MapGroup("/api/events").EventEndpoint();
app.MapGet("/", () => "Hello World!");
app.Run();


