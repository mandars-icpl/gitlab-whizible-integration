namespace GitlabModels
{
    public class Changes : IModel
    {
        [JsonPropertyName("updated_by_id")]
        public ChangeUpdatedModel? UpdatedById { get; set; }

        [JsonPropertyName("updated_at")]
        public ChangeUpdatedModel? UpdatedAt { get; set; }

        [JsonPropertyName("labels")]
        public ChangeLabelModel? Labels { get; set; }


    }

    public class ChangeUpdatedModel : IModel
    {
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
        [JsonPropertyName("current")]
        public string? Current { get; set; }
    }

    public class ChangeLabelModel : IModel
    {
        [JsonPropertyName("previous")]
        public List<Label>? Previous { get; set; }
        [JsonPropertyName("current")]
        public List<Label>? Current { get; set; }
    }
}
