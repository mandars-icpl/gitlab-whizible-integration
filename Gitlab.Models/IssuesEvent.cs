namespace Gitlab.Models;

public class IssuesEvent : IModel
{
    [JsonPropertyName("object_kind")]
    public string? ObjectKind { get; set; }

    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }

    [JsonPropertyName("user")]
    public User? User { get; set; }

    [JsonPropertyName("project")]
    public Project? Project { get; set; }

    [JsonPropertyName("object_attributes")]
    public IssueObjectAttributes? ObjectAttributes { get; set; }

    [JsonPropertyName("repository")]
    public Repository? Repository { get; set; }

    [JsonPropertyName("assignees")]
    public List<User>? Assignees { get; set; }

    [JsonPropertyName("assignee")]
    public User? Assignee { get; set; }

    [JsonPropertyName("labels")]
    public List<Label>? Labels { get; set; }

    [JsonPropertyName("changes")]
    public Changes? Changes { get; set; }

}
