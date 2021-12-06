using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Interface.Pages
{
    [Authorize(Policy = "HumanResourceManager")]
    public class HumanResourceManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
