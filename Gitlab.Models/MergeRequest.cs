using Gitlab.Models;

namespace GitlabModels;

public class MergeRequest : IModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("target_branch")]
    public string? TargetBranch { get; set; }

    [JsonPropertyName("source_branch")]
    public string? SourceBranch { get; set; }

    [JsonPropertyName("source_project_id")]
    public int SourceProjectId { get; set; }

    [JsonPropertyName("author_id")]
    public int AuthorId { get; set; }

    [JsonPropertyName("assignee_id")]
    public int AssigneeId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("milestone_id")]
    public int MileStoneId { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("merge_status")]
    public string? MergeStatus { get; set; }

    [JsonPropertyName("target_project_id")]
    public int TargetProjectId { get; set; }

    [JsonPropertyName("iid")]
    public int Iid { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("labels")]
    public List<Label> Labels { get; set; }

    [JsonPropertyName("source")]
    public ProjectInfo? Source { get; set; }

    [JsonPropertyName("target")]
    public ProjectInfo? Target { get; set; }

    [JsonPropertyName("last_commit")]
    public Commit? LastCommit { get; set; }

    [JsonPropertyName("work_in_progress")]
    public bool WorkInProgress { get; set; }

    [JsonPropertyName("draft")]
    public bool Draft { get; set; }

    [JsonPropertyName("assignee")]
    public User? Assignee { get; set; }

    [JsonPropertyName("detailed_merge_status")]
    public string? DetailedMergeStatus { get; set; }


}

public class ProjectInfo
{
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

    [JsonPropertyName("homepage")]
    public string? Homepage { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("ssh_url")]
    public string? SshUrl { get; set; }

    [JsonPropertyName("http_url")]
    public string? HttpUrl { get; set; }
}
