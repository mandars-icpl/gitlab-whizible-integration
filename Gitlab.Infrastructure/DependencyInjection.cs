namespace Gitlab.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddGitlabInfrastructureServices(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddScoped<AddIssue>();
        return service;
    }
}
