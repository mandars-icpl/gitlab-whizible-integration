namespace GitlabModels
{
    public class Changes : IModel
    {
        [JsonPropertyName("updated_by_id")]
        public ChangeUpdatedModel<int>? UpdatedById { get; set; }

        [JsonPropertyName("updated_at")]
        public ChangeUpdatedModel<string>? UpdatedAt { get; set; }

        [JsonPropertyName("labels")]
        public ChangeLabelModel? Labels { get; set; }


    }

    public class ChangeUpdatedModel<T> : IModel
    {
        [JsonPropertyName("previous")]
        public T? Previous { get; set; }
        [JsonPropertyName("current")]
        public T? Current { get; set; }
    }

    public class ChangeLabelModel : IModel
    {
        [JsonPropertyName("previous")]
        public List<Label>? Previous { get; set; }
        [JsonPropertyName("current")]
        public List<Label>? Current { get; set; }
    }
}
