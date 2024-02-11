using Microsoft.AspNetCore.Components;

namespace MyPortafolio.Components
{
    public partial class MenuIcon
    {
        [Parameter]
        public string IconName { get; set; }
        [Parameter]
        public string Href { get; set; }
    }

    public class SideMenuItem
    {
        public string IconName { get; set; }
        public string Href { get; set; }
    }
}