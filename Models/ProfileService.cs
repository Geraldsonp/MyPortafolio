using System.Net.Http.Json;
using MyPortafolio.Models;

namespace MyPortafolio;

public class ProfileService
{

    public Profile Profile { get; private set; }

    //create notify event for event handler StatehasChanged
    public event Action OnProfileChanged;

    private void NotifyProfileChanged()
    {
        OnProfileChanged?.Invoke();
    }

    public void SetProfile(Profile profile)
    {
        Profile = profile;
        NotifyProfileChanged();
    }

    public ProfileService()
    {
        Profile = new Profile();
    }

    public IEnumerable<Social> GetSocials()
    {
        return Profile.Socials;
    }

    public IEnumerable<Project> GetProjects()
    {
        return Profile.Projects;
    }

    public IEnumerable<Experience> GetExperiences()
    {
        return Profile.Experience;
    }
}
