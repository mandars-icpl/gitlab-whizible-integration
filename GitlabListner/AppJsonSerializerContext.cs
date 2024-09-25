using GitlabModels;
using System.Text.Json.Serialization;

namespace GitlabListner;


[JsonSerializable(typeof(IssuesEvent))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}
