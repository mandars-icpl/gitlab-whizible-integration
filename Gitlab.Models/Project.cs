namespace Gitlab.Models;

public class Project : IModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("web_url")]
    public string? WebUrl { get; set; }

    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    [JsonPropertyName("git_ssh_url")]
    public string? GitSshUrl { get; set; }

    [JsonPropertyName("git_http_url")]
    public string? GitHttpUrl { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("visibility_level")]
    public int VisibilityLevel { get; set; }

    [JsonPropertyName("path_with_namespace")]
    public string? PathWithNamespace { get; set; }

    [JsonPropertyName("default_branch")]
    public string? DefaultBranch { get; set; }

    [JsonPropertyName("ci_config_path")]
    public string? CiConfigPath { get; set; }

    [JsonPropertyName("homepage")]
    public string? Homepage { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("ssh_url")]
    public string? SshUrl { get; set; }

    [JsonPropertyName("http_url")]
    public string? HttpUrl { get; set; }

}
