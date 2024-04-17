using System.Text.Json.Serialization;

namespace MyPortafolio.Models;

public class Social
{
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Link")]
    public string Link { get; set; }

    [JsonPropertyName("Icon")]
    public string Icon { get; set; }
}