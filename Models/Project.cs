using System.Text.Json.Serialization;

namespace MyPortafolio.Models;

public class Project
{
    [JsonPropertyName("Name")] public string Name { get; set; }

    [JsonPropertyName("Description")] public string Description { get; set; }

    [JsonPropertyName("Link")] public string Link { get; set; }
    [JsonPropertyName("CodeLink")] public string CodeLink { get; set; }
    [JsonPropertyName("TechStack")] public string TechStack { get; set; }

    [JsonPropertyName("Image")] public string Image { get; set; }
    public ProjectStage Stage { get; set; }
}

public enum ProjectStage
{
    Development,
    Completed
}