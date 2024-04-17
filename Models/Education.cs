using System.Text.Json.Serialization;

namespace MyPortafolio.Models;

public class Education
{
    [JsonPropertyName("Institution")]
    public string Institution { get; set; }

    [JsonPropertyName("Course")]
    public string Course { get; set; }

    [JsonPropertyName("Start")]
    public string Start { get; set; }

    [JsonPropertyName("End")]
    public string End { get; set; }
}