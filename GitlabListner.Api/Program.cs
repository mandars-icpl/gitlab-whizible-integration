var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGitlabInfrastructure();
builder.Services.AddTransient<IssueEventListener>();

// fetch the secret key from the environment
var secret = Environment.GetEnvironmentVariable("GITLAB-TOKEN");


var app = builder.Build();


if (!builder.Environment.IsDevelopment())
{
    var port = Environment.GetEnvironmentVariable("PORT") ?? "5102";
    app.Urls.Add($"http://*:{port}");
}

app.UseMiddleware<ApiAuth.GitlabSecretKeyCheck>(secret);
//app.MapGroup("/api/events").EventEndpoint();
app.MapGet("/", () => "Hello World!");
app.MapGet("/api/events", static () => Results.Ok("This endpoint handles webhook trigger events for different events such as issues, push , etc"));
app.MapPost("/api/events/issues/", (IssueEventListener handler, IssuesEvent issuesEvent) => handler.Handler(issuesEvent));
app.UseHttpsRedirection();
app.Run();


