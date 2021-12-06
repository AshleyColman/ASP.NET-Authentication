using AuthenticationLibrary.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Interface.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid == false) return Page();

            if (Credential.Username == "admin"
                && Credential.Password == "password")
            {
                List<Claim> claims = new()
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@gmail.com"),
                    new Claim("Department", "HumanResource"),
                    new Claim("Admin", "true"),
                    new Claim("Manager", "true"),
                };
                ClaimsIdentity identity = new(claims, "MyCookieAuth");
                ClaimsPrincipal principal = new(identity);

                await HttpContext.SignInAsync("MyCookieAuth", principal);
                return RedirectToPage("/index");
            }
            else
            {
                return Page();
            }
        }
    }
}
