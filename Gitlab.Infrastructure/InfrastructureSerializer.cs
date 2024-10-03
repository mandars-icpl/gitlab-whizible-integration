using Gitlab.Infrastructure.Events.Issues;
using System.Text.Json.Serialization;

namespace Gitlab.Infrastructure;

[JsonSerializable(typeof(WzIssue))] 
public partial class InfrastructureSerializer : JsonSerializerContext
{
}
