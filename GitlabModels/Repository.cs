namespace GitlabModels;

public class Repository : IModel
{
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? Description { get; set; }
    public string? Homepage { get; set; }
}
