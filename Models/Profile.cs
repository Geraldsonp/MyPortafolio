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

	public class Social
	{
		[JsonPropertyName("Name")]
		public string Name { get; set; }

		[JsonPropertyName("Link")]
		public string Link { get; set; }

		[JsonPropertyName("Icon")]
		public string Icon { get; set; }
	}

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
		public List<Skill> Skill { get; set; } = new List<Skill>();

		[JsonPropertyName("Education")]
		public List<Education> Education { get; set; } = new List<Education>();

		[JsonPropertyName("Experience")]
		public List<Experience> Experience { get; set; } = new List<Experience>();

		[JsonPropertyName("Projects")]
		public List<Project> Projects { get; set; } = new List<Project>();

		[JsonPropertyName("Socials")]
		public List<Social> Socials { get; set; } = new List<Social>();
	}


}
