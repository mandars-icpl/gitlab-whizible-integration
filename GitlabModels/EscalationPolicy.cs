namespace GitlabModels
{
    public class EscalationPolicy : IModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}