namespace MyPortafolio.Components
{
	public partial class HeroSection
	{
		private IEnumerable<Skill> _skills = new List<Skill>();
		private int _skillIndex = 0;
		private string YearsOfExperience => ((DateTime.Now - new DateTime(2022, 1, 1)).TotalDays / 365).ToString("0");
		private readonly List<Skill> skills =
			[
				new() { Name = "C#", Type = SkillType.Language.ToString() },
				new() { Name = "JavaScript", Type = SkillType.Language.ToString() },
				new() { Name = "NodeJs", Type = SkillType.FrameWork.ToString() },
				new() { Name = "VueJs", Type = SkillType.FrameWork.ToString() },
				new() { Name = "HTML", Type = SkillType.Other.ToString() },
				new() { Name = "CSS", Type = SkillType.Other.ToString() },
				new() { Name = "Blazor", Type = SkillType.FrameWork.ToString() },
				new() { Name = "ASP.NET Core", Type = SkillType.FrameWork.ToString() },
				new() { Name = "EF Core", Type = SkillType.FrameWork.ToString() },
				new() { Name = "SQL Server", Type = SkillType.Database.ToString() },
				new() { Name = "Azure", Type = SkillType.Cloud.ToString() },
				new() { Name = "Git", Type = SkillType.Other.ToString() },
				new() { Name = "GitHub", Type = SkillType.Other.ToString() },
				new() { Name = "GitLab", Type = SkillType.Other.ToString() },
				new() { Name = "Postman", Type = SkillType.Other.ToString() }
			];
		protected override void OnInitialized()
		{
			_skills = skills.Take(4).ToList();
			_skillIndex = 4;
			// add timer event to change skill every 5 seconds
			//var timer = new Timer(ChangeSkills, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
		}

		private void ChangeSkills(object state)
		{
			_skills = skills.Skip(_skillIndex).Take(4).ToList();
			_skillIndex = _skillIndex + 4 >= skills.Count ? 0 : _skillIndex + 4;
			StateHasChanged();
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