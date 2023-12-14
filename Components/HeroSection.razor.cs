using Microsoft.AspNetCore.Components;

namespace MyPortafolio.Components
{
	public partial class HeroSection
	{
		[Parameter]
		public IEnumerable<Skill> Skills { get; set; }

		[Parameter]
		public DateTime WorkingSince { get; set; }
		private string YearsOfExperience => ((DateTime.Now - WorkingSince).TotalDays / 365).ToString("0");

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