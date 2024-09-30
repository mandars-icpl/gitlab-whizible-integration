namespace Gitlab.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddGitlabInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IIssueEventService, IssueEventService>();
        services.AddScoped<IIssueEventRepository, IssueRepository>();
        return services;
    }
}
