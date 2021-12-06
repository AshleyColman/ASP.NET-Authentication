using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Interface.Pages
{
    [Authorize(Policy = "HumanResource")]
    public class HumanResourceModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
