using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace AuthenticationAuthorization.Web.Pages.Account
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
            if(!ModelState.IsValid) return Page();

            //verify the credential
            if(Credential.UserName=="admin"&&Credential.Password=="password")
            {
                // creating security context
                var claims = new List<Claim> {
                     new Claim(ClaimTypes.Name,"admin"),
                     new Claim(ClaimTypes.Email,"admin@website.com"),
                     new Claim("Department","HR"),
                     new Claim("Admin","true"),
                     new Claim("Manager","true"),
                     new Claim("EmploymentDate","2024-03-28")
                };
                var identity=new ClaimsIdentity(claims,"MyCookieAuth");
                ClaimsPrincipal claimsPrincipal= new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
    public class Credential
    {
        [Required]

        [Display(Name ="User Name")]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
