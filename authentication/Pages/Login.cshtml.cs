using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;

namespace authentication.Pages
{
	public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        [BindProperty]
        public Login login { get; set; } = null!;

        public void OnGet()
        {
        }

        public  async Task<IActionResult> OnPostAsync(string returnURL = null)
        {
            if (ModelState.IsValid)
            {
                  var result = await signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, false);
                if (result.Succeeded)
                {
                    if(returnURL == null || returnURL == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnURL);
                    }
                }
                
                    ModelState.AddModelError("", "Username od Password Incorrect");
                

            }
            
                return Page();
            
        }
    }
}
