var builder = WebApplication.CreateSlimBuilder(args);


builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = AppJsonSerializerContext.Default;
});

builder.Services.AddGitlabInfrastructure();
builder.Services.AddTransient<IssueEventListener>();

// fetch the secret key from the environment
var secret = Environment.GetEnvironmentVariable("GITLAB-TOKEN");
var port = Environment.GetEnvironmentVariable("PORT") ?? "6000";

var app = builder.Build();
app.Urls.Add($"http://*:{port}");
app.UseMiddleware<ApiAuth.GitlabSecretKeyCheck>(secret);
app.MapGroup("/api/events").EventEndpoint();
app.MapGet("/", () => "Hello World!");
app.Run();


