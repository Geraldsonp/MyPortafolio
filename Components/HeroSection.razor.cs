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
		private int ProgramingLanguagesCount { get; set; }
		private int ToolsCount { get; set; }
		protected override Task OnInitializedAsync()
		{
			return base.OnInitializedAsync();
		}
		protected override void OnParametersSet()
		{
			if (Profile != null)
			{
				YearsOfExperience = (DateTime.Now.Year - Convert.ToDateTime(Profile.WorkingSince).Year).ToString();
				ToolsCount = Profile.Skill.Count(s => s.Type == "Tool");
				Email = Profile.Socials.FirstOrDefault(s => s.Name == "Email")?.Link ?? "";
				ProgramingLanguagesCount = Profile.Skill.Count(s => s.Type == "Language");
			}
		}
	}
}