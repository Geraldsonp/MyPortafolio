using System;
using System.Text.Json.Serialization;

namespace MyPortafolio.Models
{
	// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

	public class Profile
	{
		[JsonPropertyName("Name")]
		public string Name { get; set; }

		[JsonPropertyName("Age")]
		public int Age { get; set; }

		[JsonPropertyName("WorkingSince")]
		public string WorkingSince { get; set; } = "2023";

		[JsonPropertyName("Profession")]
		public string Profession { get; set; }

		[JsonPropertyName("Location")]
		public string Location { get; set; }

		[JsonPropertyName("About")]
		public string About { get; set; }

		[JsonPropertyName("CvLink")]
		public string CvLink { get; set; }

		[JsonPropertyName("Skill")]
		public List<Skill> Skills { get; set; } = new List<Skill>();

		[JsonPropertyName("Education")]
		public List<Education> Education { get; set; } = new List<Education>();

		[JsonPropertyName("Experience")]
		public List<Experience> Experience { get; set; } = new List<Experience>();

		[JsonPropertyName("Projects")]
		public List<Project> Projects { get; set; } = new List<Project>();

		[JsonPropertyName("Socials")]
		public List<Social> Socials { get; set; } = new List<Social>();
	}

	public class Skill
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Link { get; set; }
	}
}
