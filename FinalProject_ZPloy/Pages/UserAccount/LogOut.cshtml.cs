using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_ZPloy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject_ZPloy.Pages.UserAccount
{
    public class LogOutModel : PageModel
    {
        public SignInManager<AppUser> signInManager { get; }

        public LogOutModel(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("/Tasks/GetAllTasks");
        }
    }
}
