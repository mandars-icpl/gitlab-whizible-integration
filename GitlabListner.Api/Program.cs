var builder = WebApplication.CreateSlimBuilder(args);


builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolver = AppJsonSerializerContext.Default;
});


// add jsonserialization for the Gitlab.Infrastructure whichi s InfrastructureSerializer

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
app.MapGroup("/api/events").EventEndpoint();
app.MapGet("/", () => "Hello World!");
app.Run();


