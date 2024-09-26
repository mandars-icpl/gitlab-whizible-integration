namespace GitlabModels;

public class ObjectAttributes : IModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("noteable_type")]
    public string? NoteableType { get; set; }

    [JsonPropertyName("author_id")]
    public int AuthorId { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("project_id")]
    public int ProjectId { get; set; }

    [JsonPropertyName("attachment")]
    public string? Attachment { get; set; }

    [JsonPropertyName("line_code")]
    public string? LineCode { get; set; }

    [JsonPropertyName("commit_id")]
    public string? CommitId { get; set; }

    [JsonPropertyName("noteable_id")]
    public int NoteableId { get; set; }

    [JsonPropertyName("system")]
    public string? System { get; set; }

    [JsonPropertyName("st_diff")]
    public string? StDiff { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
