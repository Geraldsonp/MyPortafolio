using Microsoft.AspNetCore.Components;
using MyPortafolio.Models;

namespace MyPortafolio.Components
{
	public partial class HeroSection
	{
		[CascadingParameter]
		public Profile Profile { get; set; }

		[Parameter]
		public string WorkingSince { get; set; } = "2022";
		private string YearsOfExperience => ((DateTime.Now - DateTime.Parse($"{WorkingSince}-01-01")).TotalDays / 365).ToString("0");

		private string GetEmail()
		{
			if (Profile == null)
				return string.Empty;

			return Profile.Social.Where(s => s.Name.ToLower() == "email").FirstOrDefault()?.Link ?? string.Empty;
		}

	}
	public class Skill
	{
		public string Name { get; set; }
		public string Type { get; set; }
	}

	public enum SkillType
	{
		Language,
		Library,
		FrameWork,
		Database,
		Cloud,
		Other
	}
}