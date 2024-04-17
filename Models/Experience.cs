using System.Text.Json.Serialization;

namespace MyPortafolio.Models;

public class Experience
{
    [JsonPropertyName("Company")]
    public string Company { get; set; }

    [JsonPropertyName("Position")]
    public string Position { get; set; }

    [JsonPropertyName("Start")]
    public string Start { get; set; }

    [JsonPropertyName("End")]
    public string End { get; set; }

    [JsonPropertyName("Description")]
    public string Description { get; set; }
}