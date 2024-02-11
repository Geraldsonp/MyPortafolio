using Microsoft.AspNetCore.Components;

namespace MyPortafolio.Components
{
	public partial class HeroSection
	{
		[Parameter]
		public IEnumerable<Skill> Skills { get; set; } = new List<Skill>();

		[Parameter]
		public string WorkingSince { get; set; } = "2022";
		private string YearsOfExperience => ((DateTime.Now - DateTime.Parse($"{WorkingSince}-01-01")).TotalDays / 365).ToString("0");

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