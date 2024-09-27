using System.Text.Json.Serialization;

namespace GitlabListener;


[JsonSerializable(typeof(IssuesEvent))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}
