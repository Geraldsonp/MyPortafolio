using System;
using System.Text.Json.Serialization;
using MyPortafolio.Components;

namespace MyPortafolio.Models
{
	// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
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

	public class Project
	{
		[JsonPropertyName("Name")]
		public string Name { get; set; }

		[JsonPropertyName("Description")]
		public string Description { get; set; }

		[JsonPropertyName("Link")]
		public string Link { get; set; }

		[JsonPropertyName("Image")]
		public string Image { get; set; }
	}

	public class Profile
	{
		[JsonPropertyName("Name")]
		public string Name { get; set; }

		[JsonPropertyName("Age")]
		public int Age { get; set; }

		[JsonPropertyName("WorkingSince")]
		public DateTime WorkingSince { get; set; }

		[JsonPropertyName("Profession")]
		public string Profession { get; set; }

		[JsonPropertyName("About")]
		public string About { get; set; }

		[JsonPropertyName("Skill")]
		public List<Skill> Skill { get; set; }

		[JsonPropertyName("Education")]
		public List<Education> Education { get; set; }

		[JsonPropertyName("Experience")]
		public List<Experience> Experience { get; set; }

		[JsonPropertyName("Projects")]
		public List<Project> Projects { get; set; }
	}


}
