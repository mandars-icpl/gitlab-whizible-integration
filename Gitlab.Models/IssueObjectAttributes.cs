namespace Gitlab.Models;

public class IssueObjectAttributes : IModel
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("assignee_ids")]
    public List<int> AssigneeIds { get; set; } = new List<int>();

    [JsonPropertyName("assignee_id")]
    public int? AssigneeId { get; set; }

    [JsonPropertyName("author_id")]
    public int? AuthorId { get; set; }

    [JsonPropertyName("project_id")]
    public int? ProjectId { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("updated_by_id")]
    public int? UpdatedById { get; set; }

    [JsonPropertyName("last_edited_at")]
    public string? LastEditedAt { get; set; }

    [JsonPropertyName("last_edited_by_id")]
    public int? LastEditedById { get; set; }

    [JsonPropertyName("relative_position")]
    public int? RelativePosition { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("milestone_id")]
    public int? MilestoneId { get; set; }

    [JsonPropertyName("state_id")]
    public int? StateId { get; set; }

    [JsonPropertyName("confidential")]
    public bool? Confidential { get; set; }

    [JsonPropertyName("discussion_locked")]
    public bool? DiscussionLocked { get; set; }

    [JsonPropertyName("due_date")]
    public string? DueDate { get; set; }

    [JsonPropertyName("moved_to_id")]
    public int? MovedToId { get; set; }

    [JsonPropertyName("duplicated_to_id")]
    public int? DuplicatedToId { get; set; }

    [JsonPropertyName("time_estimate")]
    public int? TimeEstimate { get; set; }

    [JsonPropertyName("total_time_spent")]
    public int? TotalTimeSpent { get; set; }

    [JsonPropertyName("human_total_time_spent")]
    public string? HumanTotalTimeSpent { get; set; }

    [JsonPropertyName("human_time_estimate")]
    public string? HumanTimeEstimate { get; set; }

    [JsonPropertyName("human_time_change")]
    public string? HumanTimeChange { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    [JsonPropertyName("iid")]
    public int? Iid { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    [JsonPropertyName("escalation_status")]
    public string? EscalationStatus { get; set; }

    [JsonPropertyName("escalation_policy")]
    public EscalationPolicy? EscalationPolicy { get; set; }

    [JsonPropertyName("labels")]
    public List<Label> Labels { get; set; } = new List<Label>();




}
