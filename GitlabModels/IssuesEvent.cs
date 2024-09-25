namespace GitlabModels;

public class IssuesEvent : IModel
{
    [JsonPropertyName("object_kind")]
    public string? ObjectKind { get; set; }

    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }

    [JsonPropertyName("user")]
    public User? User { get; set; }

    [JsonPropertyName("project_id")]
    public int ProjectId { get; set; }

    [JsonPropertyName("project")]
    public Project? Project { get; set; }

    [JsonPropertyName("repository")]
    public Repository? Repository { get; set; }

    [JsonPropertyName("object_attributes")]
    public ObjectAttributes? ObjectAttributes { get; set; }

    [JsonPropertyName("merge_request")]
    public MergeRequest? MergeRequest { get; set; }

}
