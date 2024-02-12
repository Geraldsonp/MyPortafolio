using Microsoft.AspNetCore.Components;
using MyPortafolio.Models;

namespace MyPortafolio.Components
{
	public partial class HeroSection
	{
		[CascadingParameter]
		public Profile Profile { get; set; }

		private string YearsOfExperience { get; set; }
		private string Email { get; set; }

		private int ProgramingLanguagesCount => Profile.Skill.Count(s => s.Type == "Language");

		protected override Task OnInitializedAsync()
		{
			return base.OnInitializedAsync();
		}

		protected override void OnParametersSet()
		{
			YearsOfExperience = (DateTime.Now.Year - Convert.ToDateTime(Profile.WorkingSince).Year).ToString();
			Email = Profile.Social.FirstOrDefault(s => s.Name == "Email")?.Link ?? "";
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