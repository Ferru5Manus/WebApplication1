using Newtonsoft.Json;

namespace WebApplication1.Controllers;

public class Confirmation
{
    [JsonProperty("type")]
    public string Type { get; set; }
    
    [JsonProperty("group_id")]
    public long GroupId { get; set; }
}